using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace em_plm.Controllers;

// TODO: Improve ERROR MESSAGE ifall man försöker patcha/posta med ett upptaget company name

[ApiController]
[Route("api/company")]
public class CompanyController : ControllerBase
{
    private readonly ILogger<CompanyController> _logger;
    private readonly IApplicationDbContext _applicationDbContext;
    private readonly IMapper _mapper;

    public CompanyController(ILogger<CompanyController> logger, IApplicationDbContext applicationDbContext, IMapper mapper)

    {
        _logger = logger;
        _applicationDbContext = applicationDbContext;
        _mapper = mapper;
    }

    /// <summary>
    /// Register a new Company
    /// </summary>
    /// <remarks>
    ///     POST / create/
    ///     {
    ///         "id": 0,
    ///         "name": "Backery Post",
    ///         "styles": []
    ///     }
    /// </remarks>
    /// <param name="model"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <response code="200">Return created company as ViewMode</response>
    /// <exception cref="ArgumentException">If model i null</exception>
    [HttpPost]
    public async Task<ActionResult<CompanyViewModel>> CreateAsync(CompanyViewModel model, CancellationToken cancellationToken)
    {
        if (model is null)
        {
            throw new ArgumentException(nameof(model));
        }
        try
        {
            var company = _mapper.Map<Company>(model);
            await _applicationDbContext.Companies.AddAsync(company, cancellationToken);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return Ok(_mapper.Map<CompanyViewModel>(company));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="companyId"></param>
    /// <param name="cancellation"></param>
    /// <returns></returns>
    /// <response code="200">Return created company as ViewMode</response>
    [HttpGet("{companyId:int}")]
    public ActionResult<CompanyViewModel> Get(int companyId, CancellationToken cancellation)
    {
        // TODO: Lägg till kontroll av JWT att användare tillhör företaget ?
        try
        {
            var company = _applicationDbContext.Companies.FirstOrDefault(c => c.Id == companyId);
            if (company is null) { throw new Exception("Could not find company with matching Id"); }
            return Ok(_mapper.Map<CompanyViewModel>(company));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="model"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    [HttpPatch]
    public async Task<ActionResult<CompanyViewModel>> EditAsync([FromBody] CompanyViewModel model, CancellationToken cancellationToken)
    {
        if (model is null)
        {
            throw new ArgumentException(nameof(model));
        }
        try
        {
            var company = _applicationDbContext.Companies.FirstOrDefault(c => c.Id == model.Id);
            
            if (company is null) { throw new Exception("Could not find company to update"); }

            _applicationDbContext.Entry(company).CurrentValues.SetValues(model);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return Ok(_mapper.Map<CompanyViewModel>(company));

        }
        catch (Exception ex)
        {
            // TODO: Se till att felmedelande för att namn redan finns presenteras i UI, kan inte se det nu i Swagger. Ger 400, see inner exception
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(CompanyViewModel model, CancellationToken cancellationToken)
    {
        // NOTE: If company is deleted, all linked tables below should be deleted too... 
        if (model is null)
        {
            throw new ArgumentException(nameof(model));
        }
        try
        {
            var company = _applicationDbContext.Companies.FirstOrDefault(c => c.Id == model.Id);
            if (company is null) { throw new Exception("Could not find company to delete"); }
            _applicationDbContext.Companies.Remove(company);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}