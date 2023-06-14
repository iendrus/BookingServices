using Azure.Core;
using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Persistance
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Industry>(i =>
            {
                i.HasData(new Industry()
                {
                    Id = 1,
                    Name = "Beauty",
                    Description = "Uroda; Styl życia",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                });
            });

            modelBuilder.Entity<ServiceProvider>(s =>
            {
                s.HasData(new ServiceProvider()
                {
                    Id = 1,
                    IndustryId = 1,
                    Name = "Prześwietny Salon Art-Design",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                });
                s.OwnsOne(s => s.Email).HasData(new { ServiceProviderId = 1, DomainName = "op.pl", UserName = "art-design" });
                s.OwnsOne(s => s.ContactPerson).HasData(new { ServiceProviderId = 1, FirstName = "Bob", LastName = "Kaminski" });
            }
           );

            modelBuilder.Entity<Service>(s =>
            {
                s.HasData(new Service()
                {
                    Id = 1,
                    ServiceProviderId = 1,
                    Name = "Idealny Makeup",
                    Description = "Beauty",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                });
            }
);
        }
    }
}
