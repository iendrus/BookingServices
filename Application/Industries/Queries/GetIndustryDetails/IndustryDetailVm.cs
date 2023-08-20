using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Application.Industries.Queries.GetIndustries;
using BookingServices.Domain.Entities;
using System;


namespace BookingServices.Application.Industries.Queries.GetIndustryDetails
{
    public class IndustryDetailVm : IMapFrom<Industry>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Industry, IndustryDetailVm>();
        }
    }
}
