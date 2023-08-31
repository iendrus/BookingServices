using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviders;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;


namespace BookingServices.Application.ServiceProductPersonPerformings.Queries.GetServiceProductPersonPerformings
{
    public class GetServiceProductPersonPerformingsQueryHandler : IRequestHandler<GetServiceProductPersonPerformingsQuery, ServiceProductPersonPerformingsVm>
    {
        private readonly IBookingServicesDbContext _context;
        public GetServiceProductPersonPerformingsQueryHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;

        }
        public async Task<ServiceProductPersonPerformingsVm> Handle(GetServiceProductPersonPerformingsQuery request, CancellationToken cancellationToken)
        {

            var query = from pp in _context.PersonPerformings
                        from sp in pp.ServiceProducts
                        select new ServiceProductPersonPerformingsDto
                        {
                            ServiceProductName = sp.Name,
                            PersonPerformingName = pp.FullName.ToString()
                        };

            var results = await query.AsNoTracking().ToListAsync(cancellationToken);
            return new ServiceProductPersonPerformingsVm() { ServiceProductPersonPerformings = results };
        }
    }
}
