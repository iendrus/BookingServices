using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BookingServices.Application.ServiceProviders.Queries.GetServiceProviderDetail
{
    public class ServiceProviderDatailVm : IMapFrom<ServiceProvider>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string IndustryName { get; set; }
        public string Email { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ServiceProvider, ServiceProviderDatailVm>()
                .ForMember(s => s.Email, m => m.MapFrom(src => src.Email.ToString()))
                .ForMember(s => s.IndustryName, m => m.MapFrom(src => src.Industry.Name));

        }
    }


}
