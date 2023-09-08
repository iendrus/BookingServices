using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.Providers.Commands.CreateProvider;
using BookingServices.Domain.Entities;
using MediatR;
using System;

namespace BookingServices.Application.Industries.Commands.CreateIndustry
{
    public class UpdateIndustryCommandHandler : IRequestHandler<CreateIndustryCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public UpdateIndustryCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateIndustryCommand request, CancellationToken cancellationToken)
        {
            var industry = _mapper.Map<Industry>(request);

            _context.Industries.Add(industry);
            await _context.SaveChangesAsync(cancellationToken);
            return industry.Id;
        }

    }
}
