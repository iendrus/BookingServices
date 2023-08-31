using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.Industries.Queries.GetIndustryDetails;
using BookingServices.Application.ServiceProducts.Queries.GetServiceProductDetails;
using BookingServices.Application.ServiceRecipients.Queries.GetServiceRecipientDetail;
using BookingServices.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookingServices.Application.ServiceProviders.Queries.GetServiceProviderDetail
{
    public class GetServiceProviderDatailQueryHandler : IRequestHandler<GetServiceProviderDatailQuery, ServiceProviderDatailVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetServiceProviderDatailQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<ServiceProviderDatailVm> Handle(GetServiceProviderDatailQuery request, CancellationToken cancellationToken)
        {
            var serviceProvider = _context.ServiceProviders.Where(s => s.Id == request.Id && s.IsActive == true);

            if (serviceProvider != null)
            {
                var serviceProviderVm = await serviceProvider
                    .AsNoTracking().ProjectTo<ServiceProviderDatailVm>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(cancellationToken);
                return serviceProviderVm;
            }
            throw new InvalidOperationException("Nie odnaleziono żądanego zasobu.");
        }
    }
}
