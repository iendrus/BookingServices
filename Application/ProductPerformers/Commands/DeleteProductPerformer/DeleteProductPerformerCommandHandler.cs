using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.ProductPerformers.Commands.DeleteProductPerformer
{
public class DeleteProductPerformerCommandHandler : IRequestHandler<DeleteProductPerformerCommand>
{
    private readonly IBookingServicesDbContext _context;

    public DeleteProductPerformerCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
    {
        _context = bookingServicesDbContext;
    }

    public async Task Handle(DeleteProductPerformerCommand request, CancellationToken cancellationToken)
    {
            var productPerformers = await _context.ProductPerformers.Where(p => p.PerformerId == request.PerformerId 
            && p.ProductId == request.ProductId)
               .FirstOrDefaultAsync(cancellationToken);
            if (productPerformers == null)
            {
                throw new IsNullException();
            }
            _context.ProductPerformers.Remove(productPerformers);
            await _context.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;
        }
    }
}
