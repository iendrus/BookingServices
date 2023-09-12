using AutoMapper;
using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.Industries.Commands.UpdateIndustry
{
    public class UpdateIndustryCommandHandler : IRequestHandler<UpdateIndustryCommand>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public UpdateIndustryCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task Handle(UpdateIndustryCommand request, CancellationToken cancellationToken)
        {
            var industry = await _context.Industries.Where(x => x.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (industry == null)
            {
                throw new IsNullException();
            }
            _mapper.Map(request, industry);
            await _context.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;
        }

    }
}
