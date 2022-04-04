using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace em_plm.Controllers;
[ApiController]
[Route("api/[controller]")]
public class MmntPointController : ControllerBase
{
    private readonly ILogger<StyleController> _logger;
    private readonly IApplicationDbContext _applicationDbContext;

    public MmntPointController(ILogger<StyleController> logger, IApplicationDbContext applicationDbContext)

    {
        _logger = logger;
        _applicationDbContext = applicationDbContext;
    }


    //- Add mmntPoint : FK MmntListId, MmntPoint
    //- Edit mmntPoint : MmntPointId, MmntListId
    //- Delete mmntPoint : MmntPointId, MmntListId
    // --- Hur ska de hänga ihop gällande versioner av "måttlistan" då indirekt samma mmntPoint används, men med justerade värden ev.
    // Förslag: Om mmntListId + shortName är samma = ser det som "samma mått punkt" om man vill jämföra förändingar. ? Samtiigt som det är OK att editer ShortName ?

    [HttpPost]
    public async Task<IActionResult> AddMmntPoint(CancellationToken cancellationToken, MeasurementPoint mmntPoint)
    {
        try
        { 
            var result = await _applicationDbContext.MeasurementPoints.AddAsync(mmntPoint, cancellationToken);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public IActionResult GetMmntPoint(CancellationToken cancellation, int mmntPointId)
    {
        try
        {
            var mmntList = _applicationDbContext.MeasurementPoints.FirstOrDefault(m => m.Id == mmntPointId);
            if (mmntList != null) return Ok(mmntList);
            return NotFound("No matching mmntPoint found");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{mmntListId}")]
    public IActionResult GetMmntPoints(CancellationToken cancellation, int mmntListId)
    {
        // TODO: Vilken väg är rätt att gå för att hämta alla mått i en måttlista? Vilken controller?
        try
        {
            var mmntList = _applicationDbContext.Measurements.FirstOrDefault(m => m.Id == mmntListId);
            if (mmntList != null)
            {
                if (mmntList.MeasurementPoints.Any())
                {
                    return Ok(mmntList.MeasurementPoints);
                }
                return NotFound("No mmntPoints found on this mmntList");
            }
            return NotFound("No MmntList with matching Id found");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPatch]
    public IActionResult EditMmntPoint(CancellationToken cancellationToken, int mmntListId, MeasurementPoint newMmntPoint)
    {
        try
        {
            var mmntPoint = _applicationDbContext.MeasurementPoints.FirstOrDefault(m => m.Id == newMmntPoint.Id);
            if (mmntPoint != null)
            {
                // TODO: Se över detta, hur EDIT endpoint ska hentera FK.
                mmntPoint.ShortName = newMmntPoint.ShortName;
                mmntPoint.Description = newMmntPoint.Description;
                mmntPoint.Tolerance = newMmntPoint.Tolerance;
                //mmntPoint.GradingId = newMmntPoint.GradingId;

                _applicationDbContext.MeasurementPoints.Update(mmntPoint);
                return Ok(mmntPoint);
            }
            return NotFound("MmntPoint with matching Id not found");
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}
