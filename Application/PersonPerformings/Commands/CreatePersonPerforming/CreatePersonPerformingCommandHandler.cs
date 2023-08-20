using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.PersonPerformings.Commands.CreatePersonPerforming
{
    public class CreatePersonPerformingCommandHandler : IRequestHandler<CreatePersonPerformingCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public CreatePersonPerformingCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreatePersonPerformingCommand request, CancellationToken cancellationToken)
        {
            var personPerforming = _mapper.Map<PersonPerforming>(request);

            _context.PersonPerformings.Add(personPerforming);
            await _context.SaveChangesAsync(cancellationToken);
            return personPerforming.Id;
        }
    }
}
