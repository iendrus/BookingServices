using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.Common.Mappings;
using BookingServices.Persistance;
using Microsoft.EntityFrameworkCore;
using Moq;


namespace Application.UnitTests.Common
{
    public class CommandTestBase : IDisposable
    {
        protected readonly BookingServicesDbContext _context;
        protected readonly Mock<BookingServicesDbContext> _contextMock;
        protected readonly IMapper _mapper;

        public CommandTestBase()
        {
            _contextMock = DbContextFactory.Create();
            _context = _contextMock.Object;

            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        public void Dispose()
        {
            DbContextFactory.Destroy(_context);
        }
    }
}
