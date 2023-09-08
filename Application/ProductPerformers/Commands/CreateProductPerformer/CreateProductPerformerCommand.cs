using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.ProductPerformers.Commands.CreateProductPerformer
{
    public class CreateProductPerformerCommand : IRequest<int>
    {
        public int ProductId { get; set; }
        public int PerformerId{ get; set; }

    }
}
