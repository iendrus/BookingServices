using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.Recipients.Commands.CreateRecipient
{
    public class CreateRecipientCommandHandler : IRequestHandler<CreateRecipientCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public CreateRecipientCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateRecipientCommand request, CancellationToken cancellationToken)
        {
            var recipient = _mapper.Map<Recipient>(request);

            _context.Recipients.Add(recipient);
            await _context.SaveChangesAsync(cancellationToken);
            return recipient.Id;
        }
    }
}
