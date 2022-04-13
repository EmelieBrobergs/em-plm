using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace em_plm.Controllers;

[ApiController]
[Route("api/sizerange")]
public class SizeRangeController : ControllerBase
{
    private readonly ILogger<SizeRangeController> _logger;
    private readonly IApplicationDbContext _applicationDbContext;
    private readonly IMapper _mapper;

    public SizeRangeController(ILogger<SizeRangeController> logger, IApplicationDbContext applicationDbContext, IMapper mapper )

    {
        _logger = logger;
        _applicationDbContext = applicationDbContext;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult<SizeRangeViewModel>> CreateAsync(SizeRangeViewModel model, CancellationToken cancellationToken)
    {
        if (model is null)
        {
            throw new ArgumentException(nameof(model));
        }

        try
        {
            var sizeRange
                = _mapper.Map<SizeRange>(model);
            await _applicationDbContext.SizeRanges.AddAsync(sizeRange, cancellationToken);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
          
            return Ok(_mapper.Map<SizeRangeViewModel>(sizeRange));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{sizeRangeId:int}")]
    public ActionResult<SizeRangeViewModel> Get(int sizeRangeId, CancellationToken cancellationToken)
    {
        try
        {
            var sizeRange = _applicationDbContext.SizeRanges.FirstOrDefault(s => s.Id == sizeRangeId);
            if (sizeRange is null) { throw new Exception("Could not find sizeRange with matching Id"); }
            return Ok(_mapper.Map<SizeRangeViewModel>(sizeRange));

        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="measurementId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-measurement/{measurementId:int}")]
    public async Task<ActionResult<SizeRangeViewModel>> GetByMeasurementAsync(int measurementId, CancellationToken cancellationToken)
    {
        // TODO: Lägg till kontroll av JWT att användare tillhör företaget ?
        try
        {
            var sizeRange = await _applicationDbContext.SizeRanges
                .Include(sr => sr.Sizes)
                .FirstOrDefaultAsync(s => s.MeasurementId == measurementId, cancellationToken);

            //if (await sizeRange.AnyAsync(cancellationToken) == false) { throw new Exception("No SizeRange found on assosiated Measurement");  } 
            if (sizeRange is null) { return NoContent(); }
            
            return Ok(_mapper.Map<SizeRangeViewModel>(sizeRange));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPatch]
    public async Task<ActionResult<SizeRangeViewModel>> EditAsync([FromBody] SizeRangeViewModel model, CancellationToken cancellationToken)
    {
        if (model is null)
        {
            throw new ArgumentException(nameof(model));
        }

        try
        {
            var sizeRange = _applicationDbContext.SizeRanges.FirstOrDefault(s => s.Id == model.Id);

            if(sizeRange is null) { throw new Exception("Could not find SizeRange to update."); }

            _applicationDbContext.Entry(sizeRange).CurrentValues.SetValues(model);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return Ok(_mapper.Map<SizeRangeViewModel>(sizeRange));
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpDelete("{sizeRangeId:int}")]
    public async Task<IActionResult> DeleteAsync(int sizeRangeId, CancellationToken cancellationToken)
    {
        try
        {
            var sizeRange = _applicationDbContext.SizeRanges.FirstOrDefault(s => s.Id == sizeRangeId);
            if (sizeRange is null) { throw new Exception("Could not find style to delete."); }
            _applicationDbContext.SizeRanges.Remove(sizeRange);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("delete-by-measurement/{measurementId:int}")]
    public async Task<IActionResult> DeleteByMeasurementAsync(int measurementId, CancellationToken cancellationToken)
    {
        try
        {
            var sizeRange = _applicationDbContext.SizeRanges
                .Where(s => s.MeasurementId == measurementId)
                .AsNoTracking();

            if (await sizeRange.AnyAsync(cancellationToken) == false) { throw new Exception("No SizeRange found on assosiated Measurement to delete"); }
            _applicationDbContext.SizeRanges.RemoveRange(sizeRange);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}