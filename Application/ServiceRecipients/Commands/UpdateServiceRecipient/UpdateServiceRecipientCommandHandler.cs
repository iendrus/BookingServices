using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookingServices.Application.ServiceRecipients.Commands.UpdateServiceRecipient
{
    public class UpdateServiceRecipientCommandHandler : IRequestHandler<UpdateServiceRecipientCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public UpdateServiceRecipientCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateServiceRecipientCommand request, CancellationToken cancellationToken)
        {
            var serviceRecipient = await _context.ServiceRecipients
                .Where(x => x.Id == request.Id && x.IsActive == true).FirstOrDefaultAsync(cancellationToken);
            if (serviceRecipient != null) 
            { 
                _mapper.Map(request, serviceRecipient);
                await _context.SaveChangesAsync(cancellationToken);
                return serviceRecipient.Id;
            }
            else
            {
                return 0;
            }    
        }
    }
}
