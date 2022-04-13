using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace em_plm.Controllers;

// TODO: Improve ERROR MESSAGE ifall man försöker patcha/posta med ett upptaget short name på ett measurementId

[ApiController]
[Route("api/grading")]
public class GradingController : ControllerBase
{
    private readonly ILogger<GradingController> _logger;
    private readonly IApplicationDbContext _applicationDbContext;
    private readonly IMapper _mapper;

    public GradingController(ILogger<GradingController> logger, IApplicationDbContext applicationDbContext, IMapper mapper)

    {
        _logger = logger;
        _applicationDbContext = applicationDbContext;
        _mapper = mapper;
    }


    [HttpGet("get-by-measurementpoint/{measurementPointId}")]
    public async Task<ActionResult<GradingViewModel[]>> GetByMeasurementPointAsync(int measurementPointId, CancellationToken cancellationToken)
    {
        try
        {
            var gradings = await _applicationDbContext.Gradings
                .Where(g => g.MeasurementPointId == measurementPointId)
                .AsNoTracking()
                .ToArrayAsync(cancellationToken);


            return Ok(_mapper.Map<GradingViewModel[]>(gradings));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
