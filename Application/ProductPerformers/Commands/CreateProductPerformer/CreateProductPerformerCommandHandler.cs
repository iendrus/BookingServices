using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookingServices.Application.ProductPerformers.Commands.CreateProductPerformer
{
    public class UpdateProductCommandHandler : IRequestHandler<CreateProductPerformerCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        public UpdateProductCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;
        }
        public async Task<int> Handle(CreateProductPerformerCommand request, CancellationToken cancellationToken)
        {
            Performer performer = await _context.Performers
                .Where(p => p.Id == request.PerformerId && p.IsActive == true)
                .FirstOrDefaultAsync(cancellationToken);
            if (performer != null)
            {
                var productPerformer = await _context.Products
                .Where(s => s.Id == request.ProductId
                && s.Provider.Id == performer.ProviderId // produkty tylko oferowane przez Providera
                && s.IsActive == true)
                .FirstOrDefaultAsync(cancellationToken);

                //if (productPerformer != null)
                //{ 
                //    productPerformer.Performers.Add(performer);
                //    await _context.SaveChangesAsync(cancellationToken);
                //    return 1;
                //}
            }
            return 0;
        }
    }
}
