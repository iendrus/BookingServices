using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Application.Recipients.Queries.GetRecipientDetail;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.Recipients.Commands.DeleteRecipient
{
    public class DeleteRecipientCommand : IRequest
    {
        public int Id { get; set; }

    }
}
