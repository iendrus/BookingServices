using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviderDetail;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;


namespace BookingServices.Application.Industries.Queries.GetIndustryDetails
{
    public class GetIndustryDetailQueryHandler : IRequestHandler<GetIndustryDetailQuery, IndustryDetailVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetIndustryDetailQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<IndustryDetailVm> Handle(GetIndustryDetailQuery request, CancellationToken cancellationToken)
        {
            var industry = await _context.Industries.Where(s => s.Id == request.Id && s.IsActive == true)
                .FirstOrDefaultAsync(cancellationToken);

            var industriesVm = _mapper.Map<IndustryDetailVm>(industry);
            return industriesVm;
        }
    }
}
