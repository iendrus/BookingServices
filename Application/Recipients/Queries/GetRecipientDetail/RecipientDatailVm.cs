using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;



namespace BookingServices.Application.Recipients.Queries.GetRecipientDetail
{
    public class RecipientDatailVm : IMapFrom<Recipient>
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; } 

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Recipient, RecipientDatailVm>()
                .ForMember(s => s.FullName, m => m.MapFrom(src => src.FullName.ToString()))
                .ForMember(s => s.EmailAddress, m => m.MapFrom(src => src.Email.ToString()));
        }
    }
}
