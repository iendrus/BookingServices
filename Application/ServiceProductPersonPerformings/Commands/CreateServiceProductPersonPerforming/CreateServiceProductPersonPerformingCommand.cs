using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.ServiceProductPersonPerformings.Commands.CreateServiceProductPersonPerforming
{
    public class CreateServiceProductPersonPerformingCommand : IRequest<int>
    {
        public int ServiceProductId { get; set; }
        public int PersonPerformingId{ get; set; }

    }
}
