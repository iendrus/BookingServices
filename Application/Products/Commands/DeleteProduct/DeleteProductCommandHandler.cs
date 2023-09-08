using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IBookingServicesDbContext _context;
        public DeleteProductCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;

        }

        public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.Where(s => s.Id == request.Id && s.IsActive == true)
               .FirstOrDefaultAsync(cancellationToken);
            if (product == null)
            {
                throw new IsNullException();
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;
        }
    }
}
