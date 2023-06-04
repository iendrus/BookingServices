using BookingServices.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(options => options.AddPolicy(name: "MyAllowSpecificOrigins",
   builder =>
   {
       //builder.WithOrigins("https://localhost:44359"); 
       builder.AllowAnyOrigin(); // stosujemy, jeœli chcemy upubliczniæ API
   }));

builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
{
    Title = "TestWebApplication",
    Version = "v1",
    Description = "My first Web API",
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
}));

builder.Services.AddHealthChecks();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAppliaction"));
    app.UseDeveloperExceptionPage();
}

app.UseHealthChecks("/hc");

app.UseHttpsRedirection();

app.UseRouting(); 

app.UseCors(); 

app.UseAuthorization();

app.MapControllers();

app.Run();
