using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookingServices.Application.PersonPerformings.Commands.UpdatePersonPerforming
{
    public class UpdatePersonPerformingCommandHandler : IRequestHandler<UpdatePersonPerformingCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public UpdatePersonPerformingCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdatePersonPerformingCommand request, CancellationToken cancellationToken)
        {
            var personPerforming = await _context.PersonPerformings
                .Where(x => x.Id == request.Id && x.IsActive == true).FirstOrDefaultAsync(cancellationToken);
            if (personPerforming != null) 
            { 
            _mapper.Map(request, personPerforming);
            await _context.SaveChangesAsync(cancellationToken);
            return personPerforming.Id;
            }
            else
            {
                return 0;
            }    
        }
    }
}
