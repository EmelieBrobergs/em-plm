﻿using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace em_plm.Controllers;

[ApiController]
[Route("api/measurement")]
public class MeasurementController : ControllerBase
{
    private readonly ILogger<StyleController> _logger;
    private readonly IApplicationDbContext _applicationDbContext;
    private readonly IMapper _mapper;

    public MeasurementController(ILogger<StyleController> logger, IApplicationDbContext applicationDbContext, IMapper mapper)

    {
        _logger = logger;
        _applicationDbContext = applicationDbContext;
        _mapper = mapper;
    }
    /// <summary>
    /// The post should include SizeRange and Size
    /// </summary>
    /// <param name="model"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("{sizerange-and-sizes}")]
    public async Task<ActionResult<MeasurementViewModel>> CreateAsync([FromBody] MeasurementViewModel model, CancellationToken cancellationToken)
    {
        // Nytt measurement ska skapas
        // Nytt SizeRange ska skapas med MeasurementId
        // Flera nya Size ska skapas med SizeRangeId

        if (model is null)
        {
            throw new ArgumentNullException(nameof(model));
        }

        try
        {
            // Measurement
            var measurement = _mapper.Map<Measurement>(model);
            await _applicationDbContext.Measurements.AddAsync(measurement, cancellationToken);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            var resultMeasurement = _applicationDbContext.Measurements
                .Include(m => m.SizeRange)
                .ThenInclude(sr => sr.Sizes)
                .FirstOrDefault(m => m.Id == measurement.Id);
            // Är helt onödigt att mappa tillbaka oförändrat objekt???
            //return Ok(_mapper.Map<MeasurementViewModel>(measurement));
            return Ok(_mapper.Map<MeasurementViewModel>(resultMeasurement));

        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{measurementId}")]
    public ActionResult<MeasurementViewModel> Get(int measurementId, CancellationToken cancellationToken)
    {
        // TODO: 
        // Kolla parent measurement
        // kolla size range...+ sen sizes
        // kolla measurement points...vilket sedan ger ännu dupare koll...
        try
        {
            var measurement = _applicationDbContext.Measurements.FirstOrDefault(m => m.Id == measurementId);
            if (measurement is null) { throw new Exception("Could not find measurement with matching Id"); }
            //measurement.SizeRange = _applicationDbContext.SizeRanges.FirstOrDefault(s => s.MeasurementId == measurementId);  // error 500 depth/cycle
            return Ok(_mapper.Map<MeasurementViewModel>(measurement));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// To fetch all Measurement registerd on a Style
    /// </summary>
    /// <param name="styleId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>MeasurementViewModel[] or []</returns>
    [HttpGet("get-by-style/{styleId:int}")]
    public async Task<ActionResult<MeasurementViewModel[]>> GetByStyleAsync(int styleId, CancellationToken cancellationToken)
    {
        try
        {
            var measurements = await _applicationDbContext.Measurements
                .Where(m => m.StyleId == styleId)
                .AsNoTracking()
                .ToArrayAsync(cancellationToken);

            return Ok(_mapper.Map<MeasurementViewModel[]>(measurements));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPatch]
    public async Task<ActionResult<MeasurementViewModel>> EditAsync([FromBody] MeasurementViewModel model, CancellationToken cancellationToken)
    {
        if (model is null)
        {
            throw new ArgumentException(nameof(model));
        }

        try
        {
            var measurement = _applicationDbContext.Measurements.FirstOrDefault(m => m.Id == model.Id);

            if (measurement is null) { throw new Exception("Could not find measurement to update."); }

            _applicationDbContext.Entry(measurement).CurrentValues.SetValues(model);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return Ok(_mapper.Map<MeasurementViewModel>(measurement));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{measurementId}")]
    public async Task<IActionResult> DeleteAsync(int measurementId, CancellationToken cancellationToken)
    {
        // NOTE: anropa delete till underliggande tabeller?
        try
        {
            var measurement = _applicationDbContext.Measurements.FirstOrDefault(m => m.Id == measurementId);

            if (measurement is null) { throw new Exception("Could not find measurement to delete."); }

            _applicationDbContext.Measurements.Remove(measurement);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
