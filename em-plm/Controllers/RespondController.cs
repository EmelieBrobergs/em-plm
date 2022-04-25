using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace em_plm.Controllers;

[ApiController]
[Route("api/respond")]
public class RespondController : ControllerBase
{
    private readonly ILogger<RespondController> _logger;
    private readonly IApplicationDbContext _applicationDbContext;
    private readonly IMapper _mapper;

    public RespondController(ILogger<RespondController> logger, IApplicationDbContext applicationDbContext, IMapper mapper )

    {
        _logger = logger;
        _applicationDbContext = applicationDbContext;
        _mapper = mapper;
    }

    // TODO: Allt som inlukeras i GET anrop måste också inkluderas i patch / delete anrop till denna controller !! ??

    [HttpPost]
    public async Task<ActionResult<RespondViewModel>> CreateAsync(RespondViewModel model, CancellationToken cancellationToken)
    {
        if (model is null)
        {
            throw new ArgumentException(nameof(model));
        }

        try
        {
            var respond
                = _mapper.Map<Respond>(model);
            await _applicationDbContext.Responds.AddAsync(respond, cancellationToken);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
          
            return Ok(_mapper.Map<RespondViewModel>(respond));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="respondId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("{respondId:int}")]
    public ActionResult<RespondViewModel> Get(int respondId, CancellationToken cancellationToken)
    {
        try
        {
            var respond = _applicationDbContext.Responds
                .Include(r => r.Samples)
                .ThenInclude(s => s.SampleMeasurements)
                .FirstOrDefault(r => r.Id == respondId);
            if (respond is null) { throw new Exception("Could not find sizeRange with matching Id"); }
            return Ok(_mapper.Map<RespondViewModel>(respond));

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
    public async Task<ActionResult<RespondViewModel>> GetByMeasurementAsync(int measurementId, CancellationToken cancellationToken)
    {
        try
        {
            var respond = await _applicationDbContext.Responds
                .Include(r => r.Samples)
                .ThenInclude(s => s.SampleMeasurements)
                .FirstOrDefaultAsync(r => r.MeasurementId == measurementId, cancellationToken);

            if (respond is null) { return NoContent(); }
            
            return Ok(_mapper.Map<RespondViewModel>(respond));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPatch]
    public async Task<ActionResult<RespondViewModel>> EditAsync([FromBody] RespondViewModel model, CancellationToken cancellationToken)
    {
        if (model is null)
        {
            throw new ArgumentException(nameof(model));
        }

        try
        {
            var respond = _applicationDbContext.Responds.FirstOrDefault(r => r.Id == model.Id);

            if(respond is null) { throw new Exception("Could not find Respond to update."); }

            _applicationDbContext.Entry(respond).CurrentValues.SetValues(model);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return Ok(_mapper.Map<RespondViewModel>(respond));
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpDelete("{respondId:int}")]
    public async Task<IActionResult> DeleteAsync(int respondId, CancellationToken cancellationToken)
    {
        try
        {
            var respond = _applicationDbContext.Responds.FirstOrDefault(r => r.Id == respondId);
            if (respond is null) { throw new Exception("Could not find Respond to delete."); }
            _applicationDbContext.Responds.Remove(respond);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}