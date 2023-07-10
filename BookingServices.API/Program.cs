using BookingServices.Application;
using BookingServices.Infrastructure;
using BookingServices.Persistance;
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
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(options => options.AddPolicy(name: "MyAllowSpecificOrigins",
   builder =>
   {
       //builder.WithOrigins("https://localhost:44359"); 
       builder.AllowAnyOrigin(); // stosujemy, jeœli chcemy upubliczniæ API
   }));

builder.Services.AddSwaggerGen(c =>
{
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
    //app.UseSwaggerUI();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAppliaction"));
    app.UseDeveloperExceptionPage();
}

//app.UseHealthChecks("/hc");

app.UseHttpsRedirection();

app.UseRouting(); 

app.UseCors(); 

app.UseAuthorization();

app.MapControllers();

app.Run();
