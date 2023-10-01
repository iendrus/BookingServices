using AutoMapper;
using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookingServices.Application.Performers.Commands.UpdatePerformer
{
    public class UpdatePerformerCommandHandler : IRequestHandler<UpdatePerformerCommand>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public UpdatePerformerCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task Handle(UpdatePerformerCommand request, CancellationToken cancellationToken)
        {
            var performer = await _context.Performers
                .Where(x => x.Id == request.Id && x.IsActive == 1).FirstOrDefaultAsync(cancellationToken);
            if (performer == null)
            {
                throw new IsNullException();
            }

            _mapper.Map(request, performer);
            await _context.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;
        }
    }
}
