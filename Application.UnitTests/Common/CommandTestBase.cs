using BookingServices.Persistance;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitTests.Common
{
    class CommandTestBase : IDisposable
    {
        protected readonly BookingServicesDbContext _context;
        protected readonly Mock<BookingServicesDbContext> _contextMock;
        public CommandTestBase()
        {
            //_contextMock = BookingServicesDbContextFactory;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
