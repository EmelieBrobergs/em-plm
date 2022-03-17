using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace em_plm.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StyleController : ControllerBase
{
    private readonly ILogger<StyleController> _logger;
    private readonly IApplicationDbContext _applicationDbContext;
    private readonly IMapper _mapper;

    public StyleController(ILogger<StyleController> logger, IApplicationDbContext applicationDbContext, IMapper mapper)

    {
        _logger = logger;
        _applicationDbContext = applicationDbContext;
        _mapper = mapper;
    }

    //********************************
    //- Get all styles : CompanyId (paginated serch ??)
    //- add style : CompanyId
    //- edit style : StyleId
    //- arkive style : StyleId
    //- delete style : StyleId
    //- Add Fitting : StyleId, sampleName
    //- Edit Fitting : FittingId
    //- Delete Fitting : FittingId
    //********************************

    [HttpPost]
    public async Task<IActionResult> AddStyle(CancellationToken cancellationToken, AddStyleViewModel data)
    {
        try
        {
            var style = _mapper.Map<Style>(data);
            var result = await _applicationDbContext.Style.AddAsync(style, cancellationToken);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public IActionResult GetStyle(CancellationToken cancellationToken, int styleId)
    {
        try
        {
            var style = _applicationDbContext.Style.FirstOrDefault(s => s.Id == styleId);
            if (style != null) return Ok(style);
            return NotFound("No style found with matching Id");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{companyId}")]
    public IActionResult GetStyles(CancellationToken cancellation, int companyId)
    {
        // TODO: Lägg till kontroll av JWT att användare tillhör företaget ?
        try
        {
            var styles = _applicationDbContext.Style.Where(s => s.CompanyId == companyId);
            if (styles.Any()) return Ok(styles);
            return NotFound("No styles found on assosiated Company");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPatch]
    public IActionResult EditStyle(CancellationToken cancellationToken, int StyleId, EditStyleViewModel model)
    {
        if (model is null)
        {
            throw new ArgumentException(nameof(model));
        }

        try
        {
            var style = _applicationDbContext.Style.FirstOrDefault(s => s.Id == StyleId);
            if (style != null)
            {
                style.AssignedToUserId = model.AssignedToUserId;
                style.OrderNumber = model.OrderNumber;
                style.Name = model.Name;
                style.Description = model.Description;
                style.ProductType = model.ProductType;
                style.ProductGroup = model.ProductGroup;
                //style.MmntLists = data.MmntLists // Ska denna in här, eller senare ?

                _applicationDbContext.Style.Update(style);
                return Ok(style);
            };
            return NotFound("Style Id not found");

        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}