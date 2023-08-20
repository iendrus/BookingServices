using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;



namespace BookingServices.Application.ServiceRecipients.Queries.GetServiceRecipientDetail
{
    public class ServiceRecipientDatailVm : IMapFrom<ServiceRecipient>
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; } 

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ServiceRecipient, ServiceRecipientDatailVm>()
                .ForMember(s => s.FullName, m => m.MapFrom(src => src.FullName.ToString()))
                .ForMember(s => s.EmailAddress, m => m.MapFrom(src => src.Email.ToString()));
        }
    }
}
