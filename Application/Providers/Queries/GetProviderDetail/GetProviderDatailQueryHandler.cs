using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.Industries.Queries.GetIndustryDetails;
using BookingServices.Application.Products.Queries.GetProductDetails;
using BookingServices.Application.Recipients.Queries.GetRecipientDetail;
using BookingServices.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookingServices.Application.Providers.Queries.GetProviderDetail
{
    public class GetProviderDatailQueryHandler : IRequestHandler<GetProviderDatailQuery, ProviderDatailVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetProviderDatailQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<ProviderDatailVm> Handle(GetProviderDatailQuery request, CancellationToken cancellationToken)
        {
            var provider = _context.Providers.Where(s => s.Id == request.Id && s.IsActive == 1);

            if (provider != null)
            {
                var providerVm = await provider
                    .AsNoTracking().ProjectTo<ProviderDatailVm>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(cancellationToken);
                return providerVm;
            }
            throw new InvalidOperationException("Nie odnaleziono żądanego zasobu.");
        }
    }
}
