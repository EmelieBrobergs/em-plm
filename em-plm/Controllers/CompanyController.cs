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


    [HttpPost]
    public async Task<IActionResult> AddCompany(CancellationToken cancellationToken, string name)
    {
        try
        {
            var company = _mapper.Map<Company>(name);
            var result = await _applicationDbContext.Companies.AddAsync(company, cancellationToken);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }


    [HttpGet]
    public IActionResult GetCompany(CancellationToken cancellation, int companyId)
    {
        // TODO: Lägg till kontroll av JWT att användare tillhör företaget ?
        try
        {
            var comapny = _applicationDbContext.Companies.FirstOrDefault(c => c.Id == companyId);
            if (comapny != null) return Ok(comapny);
            return NotFound("No matching company found");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }


    [HttpPatch("{companyId}")]
    public IActionResult EditCompany(CancellationToken cancellationToken, int companyId, string name)
    {

        try
        {
            var company = _applicationDbContext.Companies.FirstOrDefault(c => c.Id == companyId);
            if (company != null)
            {
                company.Name = name;

                _applicationDbContext.Companies.Update(company);
                return Ok(company);
            };
            return NotFound("Company Id not found");

        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpDelete]
    public IActionResult DeleteCompany(CancellationToken cancellationToken, Company company)
    {
        try
        {
            var result = _applicationDbContext.Companies.Remove(company);
            return Ok(result); // TODO: Fixa rätt returvärde check !
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}