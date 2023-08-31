using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProductPersonPerformings.Queries.GetServiceProductPersonPerformings
{
    public class ServiceProductPersonPerformingsDto 
    {
        public string PersonPerformingName { get; set; }
        public string ServiceProductName { get; set; }

    }
}
