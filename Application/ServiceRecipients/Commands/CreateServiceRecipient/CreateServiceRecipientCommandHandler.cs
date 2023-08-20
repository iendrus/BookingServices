using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.ServiceRecipients.Commands.CreateServiceRecipient
{
    public class CreateServiceRecipientCommandHandler : IRequestHandler<CreateServiceRecipientCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public CreateServiceRecipientCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateServiceRecipientCommand request, CancellationToken cancellationToken)
        {
            var serviceRecipient = _mapper.Map<ServiceRecipient>(request);

            _context.ServiceRecipients.Add(serviceRecipient);
            await _context.SaveChangesAsync(cancellationToken);
            return serviceRecipient.Id;
        }
    }
}
