using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Application.ServiceRecipients.Queries.GetServiceRecipientDetail;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.ServiceRecipients.Commands.DeleteServiceRecipient
{
    public class DeleteServiceRecipientCommand : IRequest
    {
        public int Id { get; set; }

    }
}
