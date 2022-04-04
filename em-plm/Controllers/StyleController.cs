using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace em_plm.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StyleController : ControllerBase
{
    private readonly ILogger<StyleController> _logger;
    private readonly IApplicationDbContext _applicationDbContext;
    private readonly IMapper _mapper;

    public StyleController(ILogger<StyleController> logger, IApplicationDbContext applicationDbContext, IMapper mapper )

    {
        _logger = logger;
        _applicationDbContext = applicationDbContext;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult<StyleViewModel>> Create(StyleViewModel styleViewModel, CancellationToken cancellationToken)
    {
        var style = _mapper.Map<Style>(styleViewModel);

        try
        {
            await _applicationDbContext.Styles.AddAsync(style, cancellationToken);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
          
            return Ok(_mapper.Map<StyleViewModel>(style));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{styleId}")]
    public IActionResult GetStyle(int styleId, CancellationToken cancellationToken)
    {
        try
        {
            var style = _applicationDbContext.Styles.FirstOrDefault(s => s.Id == styleId);
            if (style != null) return Ok(style);
            return NotFound("No style found with matching Id");

        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("get-by-company/{companyId:int}")]
    public async Task<ActionResult<StyleViewModel[]>> GetByCompany(int companyId, CancellationToken cancellationToken)
    {
        // TODO: Lägg till kontroll av JWT att användare tillhör företaget ?
        try
        {
            var styles = _applicationDbContext.Styles
                .Where(s => s.CompanyId == companyId)
                .AsNoTracking();

            if (await styles.AnyAsync(cancellationToken)) return Ok(await styles.ToArrayAsync(cancellationToken));

            return NotFound("No styles found on assosiated Company");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPatch]
    public async Task<ActionResult<StyleViewModel>> EditStyleAsync([FromBody] EditStyleViewModel model, CancellationToken cancellationToken)
    {
        if (model is null)
        {
            throw new ArgumentException(nameof(model));
        }

        try
        {
            var existingStyle = _applicationDbContext.Styles.FirstOrDefault(s => s.Id == model.Id);

            if(existingStyle is null) { throw new Exception("Could not find styleto update."); }

            _applicationDbContext.Entry(existingStyle).CurrentValues.SetValues(model);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return Ok(existingStyle);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}