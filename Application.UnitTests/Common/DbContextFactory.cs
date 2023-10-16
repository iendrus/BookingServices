using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using BookingServices.Persistance;
using Microsoft.EntityFrameworkCore;
using BookingServices.Domain.ValueObjects;
using Moq;


namespace Application.UnitTests.Common
{
    public static class DbContextFactory
    {
        public static Mock<BookingServicesDbContext> Create()
        {
            var dateTime = new DateTime(2000, 1, 1);
            var dateTimeMock = new Mock<IDateTime>();
            dateTimeMock.Setup(m => m.Now).Returns(dateTime);

            var currentUserMock = new Mock<IcurrentUserService>();
            currentUserMock.Setup(m => m.Email).Returns("test@user.pl");
            currentUserMock.Setup(m => m.IsAuthenticated).Returns(true);

            var options = new DbContextOptionsBuilder<BookingServicesDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var mock = new Mock<BookingServicesDbContext>(options, dateTimeMock.Object, currentUserMock.Object) { CallBase = true };
            var context = mock.Object;
            context.Database.EnsureCreated();

            var industry = new BookingServices.Domain.Entities.Industry() { Id = 28, Name = "Fun", Description = "Funny", CreatedBy = "s"};
            context.Industries.Add(industry);
            var provider = new BookingServices.Domain.Entities.Provider()
            {
                Id = 17,
                Nip = "880997778",
                Name = "Sielska Grupa",
                IndustryId = 1,
                Email = new Email() { DomainName = "e.pl", UserName = "ziel" },
                CreatedBy = "s"
            };
            context.Providers.Add(provider);

            var performer = new Performer()
            {
                Id = 18,
                ProviderId = 1,
                Email = new Email() { DomainName = "ra.pl", UserName = "kla" },
                FullName = new PersonName() { FirstName = "Klara", LastName = "Bąk" },
                Phone = "505505505",
                CreatedBy = "s"
            };
            context.Performers.Add(performer);
            context.SaveChanges();
            return mock;
        }

        public static void Destroy(BookingServicesDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}
