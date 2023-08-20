using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Industries.Queries.GetIndustries
{
    public class IndustriesDto : IMapFrom<Industry>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void Mapping (Profile profile)
        {
            profile.CreateMap<Industry, IndustriesDto>();
        }

    }
}
