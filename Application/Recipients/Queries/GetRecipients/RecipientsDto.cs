using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using System;

namespace BookingServices.Application.Recipients.Queries.GetRecipients
{
    public class RecipientsDto : IMapFrom<Recipient>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }

        public void Mapping(Profile profile) 
        {
            profile.CreateMap<Recipient, RecipientsDto>()
                .ForMember(s => s.FullName, m => m.MapFrom(src => src.FullName.ToString()))
                .ForMember(s => s.EmailAddress, m => m.MapFrom(src => src.Email.ToString()));
        }
    }
}
