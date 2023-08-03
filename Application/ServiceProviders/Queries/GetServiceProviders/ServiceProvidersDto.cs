using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using System;

namespace BookingServices.Application.ServiceProviders.Queries.GetServiceProviders
{
    public class ServiceProvidersDto : IMapFrom<ServiceProvider>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IndustryName { get; set; }

        public void Mapping(Profile profile) 
        {
            profile.CreateMap<ServiceProvider, ServiceProvidersDto>();
        }
    }
}
