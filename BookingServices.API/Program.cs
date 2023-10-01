using BookingServices.API;
using BookingServices.API.Service;
using BookingServices.Application;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Infrastructure;
using BookingServices.Persistance;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;


var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();

Log.Information("Application is starting up.");

var builder = WebApplication.CreateBuilder(args);

try
{
    builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));
}
catch (Exception ex)
{
    Log.Fatal(ex, "An unexpected error occurred while starting the application.");
}
finally
{
    Log.CloseAndFlush();
}

// Add services to the container.
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddPersistance(builder.Configuration);
builder.Services.AddControllers();
builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(typeof(IcurrentUserService), typeof(CurrentUserService));

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowSpecificOrigins", policy => policy.WithOrigins("https://localhost:5001"));
    // options.AddPolicy("MyAllowSpecificOrigins", policy => policy.AllowAnyOrigin()); // stosujemy, jeœli chcemy upubliczniæ API

});


builder.Services.AddAuthentication("Bearer").AddJwtBearer("Bearer", options =>
{
    options.Authority = "https://localhost:5001";
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateAudience = false
    };
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("ApiScope", policy =>
    {
        policy.RequireAuthenticatedUser();
        policy.RequireClaim("scope", "api1");
    });
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.OAuth2,
        Flows = new OpenApiOAuthFlows()
        {
            AuthorizationCode = new OpenApiOAuthFlow
            {
                AuthorizationUrl = new Uri("https://localhost:5001/connect/authorize"),
                TokenUrl = new Uri("https://localhost:5001/connect/token"),
                Scopes = new Dictionary<string, string>
                {
                    {"api1", "Full access" }
                }
            }
        }
    });
    c.OperationFilter<AuthorizeCheckOperationFilter>();
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "BookingServices",
        Version = "v1",
        Description = "The API is used to book various services with one or more providers.",
        TermsOfService = new Uri("https://github.com/iendrus/BookingServices"),
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Andrzej",
            Email = "iendrus@gmail.com",
            Url = new Uri("https://github.com/iendrus/BookingServices")
        },
        License = new Microsoft.OpenApi.Models.OpenApiLicense
        {
            Name = "Used License",
            Url = new Uri("https://github.com/iendrus/BookingServices")
        }
    });
    var filePath = Path.Combine(AppContext.BaseDirectory, "BookingServices.API.xml");
    c.IncludeXmlComments(filePath);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAppliaction v1");
        c.OAuthClientId("swagger");
        c.OAuthClientSecret("secret");
        c.OAuth2RedirectUrl("https://localhost:7191/swagger/oauth2-redirect.html");
        c.OAuthScopes("api1");
        c.OAuthUsePkce();
    });
    app.UseDeveloperExceptionPage();
}


app.UseHttpsRedirection();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.UseCors();

app.MapControllers().RequireAuthorization("ApiScope");

app.Run();
