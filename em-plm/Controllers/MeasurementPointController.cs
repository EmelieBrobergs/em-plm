using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace em_plm.Controllers;

// TODO: Improve ERROR MESSAGE ifall man försöker patcha/posta med ett upptaget short name på ett measurementId

[ApiController]
[Route("api/measurementpoint")]
public class MeasurementPointController : ControllerBase
{
    private readonly ILogger<StyleController> _logger;
    private readonly IApplicationDbContext _applicationDbContext;
    private readonly IMapper _mapper;

    public MeasurementPointController(ILogger<StyleController> logger, IApplicationDbContext applicationDbContext, IMapper mapper)

    {
        _logger = logger;
        _applicationDbContext = applicationDbContext;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult<MeasurementPointViewModel>> CreateAsync(MeasurementPointViewModel model, CancellationToken cancellationToken)
    {
        if (model is null)
        {
            throw new ArgumentException(nameof(model));
        }
        try
        {
            var errorMessage = Check_ShortName_MeasurementId_Constrain(model);
            if (errorMessage != null) { throw new Exception(errorMessage); }

            var measurementPoint = _mapper.Map<MeasurementPoint>(model);
            await _applicationDbContext.MeasurementPoints.AddAsync(measurementPoint, cancellationToken);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return Ok(_mapper.Map<MeasurementPointViewModel>(measurementPoint));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{measurementPointId:int}")]
    public ActionResult<MeasurementPointViewModel> Get(int measurementPointId, CancellationToken cancellationToken)
    {
        try
        {
            var measurementPoint = _applicationDbContext.MeasurementPoints.FirstOrDefault(m => m.Id == measurementPointId);
            if (measurementPoint is null) { throw new Exception("Could not find measurementPoint with matching Id"); }
            return Ok(_mapper.Map<MeasurementViewModel>(measurementPoint));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("get-by-measurement/{measurementId}")]
    public async Task<ActionResult<MeasurementPointViewModel[]>> GetByMeasurementAsync(int measurementId, CancellationToken cancellationToken)
    {
        try
        {
            var measurementPoints = _applicationDbContext.MeasurementPoints
                .Where(m => m.MeasurementId == measurementId)
                .AsNoTracking();

            if (await measurementPoints.AnyAsync(cancellationToken) == false) { throw new Exception("No MeasurementPoints found on assosiated Measurement"); }

            return Ok(await measurementPoints.ToArrayAsync(cancellationToken));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPatch]
    public async Task<ActionResult<MeasurementPointViewModel>> EditAsync([FromBody] MeasurementPointViewModel model, CancellationToken cancellationToken)
    {
        if (model is null)
        {
            throw new ArgumentException(nameof(model));
        }
        try
        {
            var errorMessage = Check_ShortName_MeasurementId_Constrain(model);
            if (errorMessage != null) { throw new Exception(errorMessage); }

            var measurementPoint = _applicationDbContext.MeasurementPoints.FirstOrDefault(m => m.Id == model.Id);
            if (measurementPoint is null) { throw new Exception("Could not find MeasurementPoint to update."); }

            _applicationDbContext.Entry(measurementPoint).CurrentValues.SetValues(model);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return Ok(_mapper.Map<MeasurementPointViewModel>(measurementPoint));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{measurementPointId:int}")]
    public async Task<IActionResult> DeleteAsync(int measurementPointId, CancellationToken cancellationToken)
    {
        try
        {
            var measurementPoint = _applicationDbContext.MeasurementPoints.FirstOrDefault(s => s.Id == measurementPointId);
            if (measurementPoint is null) { throw new Exception("Could not find MeasurementPoint to delete."); }
            _applicationDbContext.MeasurementPoints.Remove(measurementPoint);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("delete-by-measurement{measurementId:int}")]
    public async Task<IActionResult> DeleteByMeasurementAsync(int measurementId, CancellationToken cancellationToken)
    {
        try
        {
            var measurementPoints = _applicationDbContext.MeasurementPoints
                .Where(m => m.MeasurementId == measurementId)
                .AsNoTracking();
            
            if (await measurementPoints.AnyAsync(cancellationToken) == false) { throw new Exception("No MeasurementPoints found on assosiated Measurement to delete"); }
            _applicationDbContext.MeasurementPoints.RemoveRange(measurementPoints);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    //*********************************************************
    //*********     PRIVATE FUNCTION      *********************
    //*********************************************************
    /// <summary>
    /// Check constrins added to db tables throw EF code first in Context file
    /// </summary>
    /// <param name="model"></param>
    /// <returns>Error message or null</returns>
    private string? Check_ShortName_MeasurementId_Constrain(MeasurementPointViewModel model)
    {
        var checkConstrain = _applicationDbContext.MeasurementPoints.FirstOrDefault(m => m.MeasurementId == model.MeasurementId && m.ShortName == model.ShortName && m.Id != model.Id);
        if (checkConstrain != null) return "Short name is alredy used, must be unique for each measurement point within a measurement file.";
        return null;
    }
}
