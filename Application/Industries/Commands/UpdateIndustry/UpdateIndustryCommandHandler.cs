using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.ServiceProviders.Commands.CreateServiceProvider;
using BookingServices.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookingServices.Application.Industries.Commands.UpdateIndustry
{
    public class UpdateIndustryCommandHandler : IRequestHandler<UpdateIndustryCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public UpdateIndustryCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateIndustryCommand request, CancellationToken cancellationToken)
        {
            var industry = await _context.Industries.Where(x => x.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (industry != null)
            {
                _mapper.Map(request, industry);
                await _context.SaveChangesAsync(cancellationToken);
                return industry.Id;
            }
            else
            {
                return 0;
            }

        }

    }
}
