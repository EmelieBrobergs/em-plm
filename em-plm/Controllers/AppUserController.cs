using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Domain.Entities;

namespace em_plm.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AppUserController : ControllerBase
{
    private readonly ILogger<AppUserController> _logger;
    private readonly IApplicationDbContext _applicationDbContext;
    private readonly ITokenService _tokenService;
    private readonly IMapper _mapper;
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;

    public AppUserController(ILogger<AppUserController> logger, IApplicationDbContext applicationDbContext, ITokenService tokenService, IMapper mapper, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)

    {
        _logger = logger;
        _applicationDbContext = applicationDbContext;
        _tokenService = tokenService;
        _mapper = mapper;
        _userManager = userManager;
        _signInManager = signInManager;
    }
    /// <summary>
    /// Authenticate against API.
    /// </summary>
    /// <remarks>
    /// Sample request: BASIC USER
    ///     
    ///     POST /signin/
    ///     {
    ///          "email": "bellasofia@mail.com",
    ///          "password": "basic123A!"
    ///     }
    ///     
    /// Sample request: ADMINISTRATOR
    ///     POST /signin/
    ///     {
    ///            "email": "emelie.broberg@mail.com",
    ///            "password": "basic123A!"
    ///     }
    ///
    /// </remarks>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>Information about the authenticated user and jwtToken for authenticating requests.</returns>
    /// <response code="200">Returns user object and jwt token</response>
    /// <response code="400">If sign in failed</response>
    /// <exception cref="ArgumentException"></exception>
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SigninResponseViewModel))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
    [HttpPost("signin")]
    [AllowAnonymous]
    public async Task<ActionResult> SigninAsync(SigninViewModel data, CancellationToken cancellationToken)

    {
        if (string.IsNullOrWhiteSpace(data.Email))
        {
            throw new ArgumentException($"'{nameof(data.Email)}' cannot be null or whitespace.", nameof(data.Email));
        }
        if (string.IsNullOrWhiteSpace(data.Password))
        {
            throw new ArgumentException($"'{nameof(data.Password)}' cannot be null or whitespace.", nameof(data.Password));
        }

        try
        {
            var user = await _userManager.FindByEmailAsync(data.Email);
            if (user != null)
            {
                var checkPassword = await _userManager.CheckPasswordAsync(user, data.Password);
                if (checkPassword)
                {
                    //NOTE: claims is allways 0, create claims to db...in ScopedRoleSeederService.
                    var claimList = User.Claims.ToList();
                    var roles = await _userManager.GetRolesAsync(user);
                    foreach (var role in roles)
                    {
                        claimList.Add(new Claim(ClaimTypes.Role, role));
                    }

                    var token = _tokenService.GenerateJwtToken(user, claimList);
                    var userModel = _mapper.Map<UserViewModel>(user);
                    SigninResponseViewModel responseModel = new SigninResponseViewModel();
                    responseModel.AccessToken = token.ToString();
                    responseModel.User = userModel;
                    return Ok(responseModel);

                }
            }
            return Unauthorized("Not valid username and/or password.");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPatch]
    [Authorize]
    public async Task<ActionResult> EditUserAsync([FromBody] UserViewModel data, CancellationToken cancellationToken)
    {
        if (data is null)
        {
            throw new ArgumentNullException(nameof(data));
        }

        try
        {
            var user = await _userManager.FindByIdAsync(data.Id);
            if (user != null)
            {
                user.Email = data.Email;
                user.FirstName = data.FirstName;
                user.LastName = data.LastName;
                //user.CompanyId = data.CompanyId; // TODO: Only Role: "Administrator" should have premision to edit this field. Check jwt as in customersettings/{Company}.

                await _userManager.UpdateAsync(user);
                var userModel = _mapper.Map<UserViewModel>(user);
                return Ok(userModel);
            }
            else return NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPatch("{id}")]
    [Authorize]
    public async Task<ActionResult> EditUserPassword(string id, [FromBody] EditUserPasswordViewModel data, CancellationToken cancellationToken)
    {
        try
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var changePassword = _userManager.ChangePasswordAsync(user, data.OldPass, data.NewPass);
                if (!changePassword.Result.Succeeded)
                {
                    List<IdentityError> errorList = changePassword.Result.Errors.ToList();
                    var errors = string.Join(' ', errorList.Select(e => e.Description));
                    return BadRequest(errors);
                }
                return Ok();
            }
            else return BadRequest("User not found");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Method added so new user can be created from API and have the right format in db from start
    /// Authorize requier call be made from user with role Adminitratior
    /// </summary>
    /// <param name="data">A view model to </param>
    /// <param name="cancellationToken"></param>
    /// <returns>AppUser</returns>
    [HttpPost]
    [AllowAnonymous]
    //[Authorize(Policy = "ReruireAdministratorRole")] // TODO: To be used when role is implumented in token
    public async Task<ActionResult> RegisterUserAsync(RegisterUserViewModel data, CancellationToken cancellationToken)
    {
        var user = new AppUser
        {
            UserName = data.UserName,
            Email = data.Email,
            FirstName = data.FirstName,
            LastName = data.LastName,
            CompanyId = data.CompanyId
        };

        try
        {
            var createdUser = await _userManager.CreateAsync(user, data.Password);

            if (!createdUser.Succeeded)
            {
                List<IdentityError> errorList = createdUser.Errors.ToList();
                var errors = string.Join(' ', errorList.Select(e => e.Description));
                return BadRequest(errors);
            }

            _logger.LogInformation($"Successfuly registered {user}");

            await _userManager.AddToRoleAsync(user, "Basic user");

            var fetchUser = await _userManager.FindByEmailAsync(data.Email);
            if (fetchUser == null) return NotFound();

            //NOTE: If implumented in UI, we will probably that the user should be signedin after registation
            //return await SigninAsync(new )
            return Ok(fetchUser);
        }
        catch (Exception ex)
        {
            return Problem(ex.Message);
        }
    }
}