using Application.Common.Interfaces;
using Application.Common.Settings;
using Domain.Entities;
using Infrastructure.Persistence;
using Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using WebUI.WorkerServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<ApplicationJwtSettings>(builder.Configuration.GetSection("ApplicationJwtSettings"));
builder.Services.Configure<ConnectionStringsSettings>(builder.Configuration.GetSection("ConnectionStrings"));

builder.Services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

builder.Services.AddCors(o => o.AddPolicy("Production", builder =>
{
    builder.AllowAnyMethod()
        .AllowAnyHeader()
        .WithOrigins() //TODO: Add url
        .AllowCredentials();
}));

builder.Services.AddCors(o => o.AddPolicy("Development", builder =>
{
    builder.AllowAnyMethod()
        .AllowAnyHeader()
        .WithOrigins("http://localhost:5542", "http://127.0.0.1:5542")
        .AllowCredentials();
}));

//*****
// Added for aspNetCore.Identetyadd

builder.Services.AddIdentity<AppUser, IdentityRole<int>>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 8;
});

builder.Services.AddHostedService<ConsumeScopedServiceHostedService>();
builder.Services.AddScoped<IScopedRoleSeederService, ScopedRoleSeederService>();
//*****

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();

var jwtSettingsSection = builder.Configuration.GetSection("ApplicationJwtSettings");
var jwtSettings = jwtSettingsSection.Get<ApplicationJwtSettings>();

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(y =>
    {
        y.RequireHttpsMetadata = false;
        //x.SaveToken = true;
        y.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = false,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtSettings.SigningKey)),
            ValidateIssuer = false,
            ValidateAudience = false,

        };
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddSwaggerGen(c =>
{
    //c.OperationFilter<AuthorizeCheckOperationFilter>();

    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Em PLM Web API",
        Version = "v1",
        Description = "An API to Authenticate and retrieve data from Em PLM. Used to create new product files, store versions of measurement and history of product development to be used as templates for new poducts.",
        TermsOfService = new Uri("https://github.com/emeliebrobergs"),
        Contact = new OpenApiContact
        {
            Name = "Emelie Broberg, personal prodject",
            Email = string.Empty,
            Url = new Uri("https://github.com/emeliebrobergs"),
        }
    });

    c.AddSecurityDefinition("Bearer", //Name the security scheme
        new OpenApiSecurityScheme
        {
            Description = "JWT Authorization header using the Bearer scheme.",
            Type = SecuritySchemeType
                .Http, //We set the scheme type to http since we're using bearer authentication
            Scheme =
                "bearer" //The name of the HTTP Authorization scheme to be used in the Authorization header. In this case "bearer".
        });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Id = "Bearer", //The name of the previously defined security scheme.
                                Type = ReferenceType.SecurityScheme
                            }
                        },
                        new List<string>()
                    }
                });

    //  c.OperationFilter<AuthorizeCheckOperationFilter>();

    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("ReruireAdministratorRole",
        policy => policy.RequireRole("Administrator"));

    options.AddPolicy("ReruireSuperUserRole",
        policy => policy.RequireRole("Super user"));
});

builder.Services.AddSingleton<ITokenService, TokenService>();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseCors("Development");
    app.UseSwagger();
    app.UseSwaggerUI(c=> c.SwaggerEndpoint("/swagger/v1/swagger.json", "Em PLM v1"));
}

if (app.Environment.IsProduction())
{
    app.UseCors("Production");
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
