using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;


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
            var productPerformer = await _context.Products
                .Where(s => s.Id == request.ProductId && s.IsActive == true)
                .FirstOrDefaultAsync(cancellationToken);
            if (productPerformer == null)
            {
                throw new IsNullException();
            }
            //var performer = productPerformer.Performers
            //    .FirstOrDefault(p => p.Id == request.PerformerId && p.IsActive == true);

            //if (performer == null)
            //{
            //    throw new IsNullException();
            //}

            //productPerformer.Performers.Remove(performer);
            //await _context.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;
        }
    }
}
