using AutoMapper;
using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookingServices.Application.Recipients.Commands.UpdateRecipient
{
    public class UpdateRecipientCommandHandler : IRequestHandler<UpdateRecipientCommand>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public UpdateRecipientCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task Handle(UpdateRecipientCommand request, CancellationToken cancellationToken)
        {
            var recipient = await _context.Recipients
                .Where(x => x.Id == request.Id && x.IsActive == true).FirstOrDefaultAsync(cancellationToken);
            if (recipient == null)
            {
                throw new IsNullException();
            }
            _mapper.Map(request, recipient);
            await _context.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;
        }
    }
}
