using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ProductPerformers.Queries.GetProductPerformers
{
    public class ProductPerformersDto 
    {
        public int PerformerId { get; set; }
        public string PerformerName { get; set; }
        public int ProductId { get; set; }   
        public string ProductName { get; set; }
        public string ProviderName { get; set; }

    }
}
