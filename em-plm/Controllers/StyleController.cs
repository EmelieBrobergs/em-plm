using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace em_plm.Controllers;

[ApiController]
[Route("api/style")]
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
    public async Task<ActionResult<StyleViewModel>> CreateAsync(StyleViewModel model, CancellationToken cancellationToken)
    {
        if (model is null)
        {
            throw new ArgumentException(nameof(model));
        }

        try
        {
            var errorMessage = Check_StyleNumber_CompanyId_Constrain(model);
            if (errorMessage != null) { throw new Exception(errorMessage); }

            var style = _mapper.Map<Style>(model);
            await _applicationDbContext.Styles.AddAsync(style, cancellationToken);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
          
            return Ok(_mapper.Map<StyleViewModel>(style));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{styleId:int}")]
    public async Task<ActionResult<StyleViewModel>> GetAsync(int styleId, CancellationToken cancellationToken)
    {
        try
        {
            var style = _applicationDbContext.Styles
                .Include(s => s.Fittings)
                .Include(s => s.Measurements)
                    .ThenInclude(me => me.SizeRange)
                        .ThenInclude(sr => sr.Sizes)
                .Include(s => s.Measurements)
                    .ThenInclude(me => me.MeasurementPoints)
                .FirstOrDefault(s => s.Id == styleId);
            if (style is null) { throw new Exception("Could not find style with matching Id"); }

            return Ok(_mapper.Map<StyleViewModel>(style));

        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }


    [HttpGet("get-by-company/{companyId:int}")]
    public async Task<ActionResult<StyleViewModel[]>> GetByCompanyAsync(int companyId, CancellationToken cancellationToken)
    {
        // TODO: Vill få med storleksbågen ( = size Range i senaste skapade måttlistan på stylen)
        try
        {
            var styles = await _applicationDbContext.Styles
                .Include(s => s.Fittings)
                 .Include(s => s.Measurements)
                .Where(s => s.CompanyId == companyId)
                .AsNoTracking()
                .ToArrayAsync(cancellationToken);

            //if (styles.Length == 0) { throw new Exception("No Styles found on assosiated Company");  }
    
            return Ok(_mapper.Map<StyleViewModel[]>(styles));  // fel returvärde ?
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPatch]
    public async Task<ActionResult<StyleViewModel>> EditAsync([FromBody] StyleViewModel model, CancellationToken cancellationToken)
    {
        if (model is null)
        {
            throw new ArgumentException(nameof(model));
        }

        try
        {
            var errorMessage = Check_StyleNumber_CompanyId_Constrain(model);
            if (errorMessage != null) { throw new Exception(errorMessage); }

            var existingStyle = _applicationDbContext.Styles.FirstOrDefault(s => s.Id == model.Id);
            if(existingStyle is null) { throw new Exception("Could not find style to update."); }

            _applicationDbContext.Entry(existingStyle).CurrentValues.SetValues(model);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return Ok(_mapper.Map<StyleViewModel>(existingStyle));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{styleId:int}")]
    public async Task<IActionResult> DeleteAsync(int styleId, CancellationToken cancellationToken)
    {
        try
        {
            var style = _applicationDbContext.Styles.FirstOrDefault(s => s.Id == styleId);
            if (style is null) { throw new Exception("Could not find style to delete."); }
            _applicationDbContext.Styles.Remove(style);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("delete-by-company/{companyId:int}")]
    public async Task<IActionResult> DeleteByCompanyAsync(int companyId, CancellationToken cancellationToken)
    {
        // TODO: Lägg till kontroll av JWT att användare tillhör företaget ?
        // TODO: Kontroll av AppUser-Role ?
        try
        {
            var styles = _applicationDbContext.Styles
                .Where(s => s.CompanyId == companyId)
                .AsNoTracking();

            if (await styles.AnyAsync(cancellationToken) == false) { throw new Exception("No Styles found on assosiated Company to delete"); }
            _applicationDbContext.Styles.RemoveRange(styles);
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
    private string? Check_StyleNumber_CompanyId_Constrain(StyleViewModel model)
    {
        var checkStyleNumberCompanyIdConstrain = _applicationDbContext.Styles.FirstOrDefault(s => s.StyleNumber == model.StyleNumber && s.CompanyId == model.CompanyId && s.Id != model.Id);
        if (checkStyleNumberCompanyIdConstrain != null) return "Style number is taken, must be unique for each style of a Company.";
        return null;
    }

}