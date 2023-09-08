using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.Performers.Commands.CreatePerformer
{
    public class CreatePerformerCommandHandler : IRequestHandler<CreatePerformerCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public CreatePerformerCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreatePerformerCommand request, CancellationToken cancellationToken)
        {
            var performer = _mapper.Map<Performer>(request);

            _context.Performers.Add(performer);
            await _context.SaveChangesAsync(cancellationToken);
            return performer.Id;
        }
    }
}
