using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.ServiceProducts.Commands.UpdateServiceProduct
{
    public class UpdateServiceProductCommandHandler : IRequestHandler<UpdateServiceProductCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public UpdateServiceProductCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateServiceProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.ServiceProducts.Where(x => x.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (product != null)
            {
                _mapper.Map(request, product);
                await _context.SaveChangesAsync(cancellationToken);
                return product.Id;
            }
            else
            {
                return 0;
            }

        }

    }
}
