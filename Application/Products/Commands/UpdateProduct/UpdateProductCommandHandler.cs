using AutoMapper;
using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public UpdateProductCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.Where(x => x.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (product == null)
            {
                throw new IsNullException();
            }
            _mapper.Map(request, product);
            await _context.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;
        }

    }
}
