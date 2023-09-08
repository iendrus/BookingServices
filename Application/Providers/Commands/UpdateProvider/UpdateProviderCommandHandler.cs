using AutoMapper;
using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.Providers.Commands.CreateProvider;
using BookingServices.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookingServices.Application.Providers.Commands.UpdateProvider
{
    public class UpdateProviderCommandHandler : IRequestHandler<UpdateProviderCommand>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public UpdateProviderCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task Handle(UpdateProviderCommand request, CancellationToken cancellationToken)
        {
            var provider = await _context.Providers.Where(x => x.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (provider == null)
            {
                throw new IsNullException();
            }
            _mapper.Map(request, provider);
            await _context.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;
        }
    }
}
