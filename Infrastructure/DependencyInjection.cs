using BookingServices.Application.Common.Interfaces;
using BookingServices.Infrastructure.ExternalAPI.OMDB;
using BookingServices.Infrastructure.FileStore;
using BookingServices.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace BookingServices.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection  AddInfrastructure (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient("OmdbClient", options =>
            {
                options.BaseAddress = new Uri("http://www.omdbapi.com");
                options.Timeout = new TimeSpan(0, 0, 10);
                options.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }).ConfigurePrimaryHttpMessageHandler(sp => new HttpClientHandler());

            services.AddScoped<IOmdbClient, OmdbClient>();
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IFileStore, FileStore.FileStore>();
            services.AddTransient<IFileWrapper, FileWrapper>();
            services.AddTransient<IDirectoryWrapper, DirectoryWrapper>();
            return services;
        }
    }
}
