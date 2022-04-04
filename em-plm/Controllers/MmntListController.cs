using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace em_plm.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MmntListController : ControllerBase
{
    private readonly ILogger<StyleController> _logger;
    private readonly IApplicationDbContext _applicationDbContext;
    private readonly IMapper _mapper;

    public MmntListController(ILogger<StyleController> logger, IApplicationDbContext applicationDbContext, IMapper mapper)

    {
        _logger = logger;
        _applicationDbContext = applicationDbContext;
        _mapper = mapper;
    }

    //- Add mmntList : FK StyleId
    // - GET one
    // - GET all for one style
    //- Edit mmntList : MmntListId
    //- Arcive mmntList : MmntListId   <--- hur ?
    //- Delete mmntList : MmntListId

    [HttpPost]
    public async Task<IActionResult> AddMmntList(CancellationToken cancellationToken, MmntListViewModel model)
    {
        try
        {
            var mmntList = _mapper.Map<Measurement>(model);
            var result = await _applicationDbContext.Measurements.AddAsync(mmntList, cancellationToken);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public IActionResult GetMmntList(CancellationToken cancellation, int mmntListId)
    {
        try
        {
            var mmntList = _applicationDbContext.Measurements.FirstOrDefault(m => m.Id == mmntListId);
            if (mmntList != null) return Ok(mmntList);
            return NotFound("No matching company found");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{styleId}")]
    public IActionResult GetMmntLists(CancellationToken cancellation, int styleId)
    {
        try
        {
            var mmntList = _applicationDbContext.Measurements.Where(m => m.StyleId == styleId);
            if (mmntList.Any()) return Ok(mmntList);
            return NotFound("No MmntLists found on assosiated Style");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPatch]
    public IActionResult EditMmntList(CancellationToken cancellationToken, int mmntListId, MmntListViewModel model)
    {
        if (model is null)
        {
            throw new ArgumentException(nameof(model));
        }

        try
        {
            var mmntList = _applicationDbContext.Measurements.FirstOrDefault(m => m.Id == mmntListId);
            if (mmntList != null)
            {
                mmntList.Name = model.Name;
                mmntList.SizeRange = model.SizeRange;
                mmntList.UnitOfMeasure = model.UnitOfMeasure;
                mmntList.StyleId = model.StyleId;

                _applicationDbContext.Measurements.Update(mmntList);
                return Ok(mmntList);
            }
            return NotFound("MmntList with matching Id not found");
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}
