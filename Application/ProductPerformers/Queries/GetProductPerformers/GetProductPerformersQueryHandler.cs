using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.Providers.Queries.GetProviders;
using BookingServices.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;


namespace BookingServices.Application.ProductPerformers.Queries.GetProductPerformers
{
    public class GetProductPerformersQueryHandler : IRequestHandler<GetProductPerformersQuery, ProductPerformersVm>
    {
        private readonly IBookingServicesDbContext _context;
        public GetProductPerformersQueryHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;

        }
        public async Task<ProductPerformersVm> Handle(GetProductPerformersQuery request, CancellationToken cancellationToken)
        {

            var query = from pp in _context.Performers 
                         where 
                        pp.IsActive == true
                        && (request.PerformerName == null || 
                        (pp.FullName.FirstName.StartsWith(request.PerformerName) 
                            || pp.FullName.LastName.StartsWith(request.PerformerName)))
                        && (request.ProviderName == null || pp.Provider.Name.StartsWith(request.ProviderName))
                        && (request.PerformerId == null || pp.Id == request.PerformerId)
                        && (request.ProviderId == null || pp.Provider.Id == request.ProviderId)
                        select new ProductPerformersDto
                        {


                            PerformerId = pp.Id,
                            PerformerName = pp.FullName.ToString(),

                        };

            var results = await query.AsNoTracking().ToListAsync(cancellationToken);
            return new ProductPerformersVm() { ProductPerformers = results };
        }
    }
}
