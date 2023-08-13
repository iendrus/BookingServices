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
                i.HasData(
                new Industry()
                {
                    Id = 1,
                    Name = "Beauty",
                    Description = "Uroda; Styl życia",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                },
                new Industry()
                {
                    Id = 2,
                    Name = "Fun",
                    Description = "Rozrywka, zabawa",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                });
                
            });

            modelBuilder.Entity<ServiceProvider>(s =>
            {
                s.HasData(
                new ServiceProvider()
                {
                    Id = 1,
                    IndustryId = 1,
                    Name = "Prześwietny Salon Art-Design",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true,
                },
                new ServiceProvider()
                {
                    Id = 2,
                    IndustryId = 1,
                    Name = "Colormix",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                }

                );
                s.OwnsOne(s => s.Email).HasData(
                    new { ServiceProviderId = 1, DomainName = "op.pl", UserName = "art-design" },
                    new { ServiceProviderId = 2, DomainName = "wp.pl", UserName = "color" }
                    );
                s.OwnsOne(s => s.ContactPerson).HasData(
                    new { ServiceProviderId = 1, FirstName = "Bob", LastName = "Kaminski" },
                    new { ServiceProviderId = 2, FirstName = "Lukas", LastName = "Kolorowy" }
                    );
                s.OwnsOne(s => s.Address).HasData(
                    new { ServiceProviderId = 1, City = "Dulcza", Street = "Miła", ZipCode ="33-220", Number="14" },
                    new { ServiceProviderId = 2, City = "Flismanowa", ZipCode = "32-120", Number = "234A" }
                    );
            });

            modelBuilder.Entity<Product>(s =>
            {
                s.HasData(
                new Product()
                {
                    Id = 1,
                    ServiceProviderId = 1,
                    Name = "Idealny Makeup",
                    Description = "Beauty",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                },
                new Product()
                {
                    Id = 2,
                    ServiceProviderId = 1,
                    Name = "Golenie jak złoto",
                    Description = "",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                },
                new Product()
                {
                    Id = 3,
                    ServiceProviderId = 2,
                    Name = "Kolor za zeta",
                    Description = "",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                });
            });

            modelBuilder.Entity<ServiceRecipient>(s =>
            {
                s.HasData(
                new ServiceRecipient()
                {
                    Id = 1,
                    Phone = "500500500",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                },
                new ServiceRecipient()
                {
                    Id = 2,
                    Phone = "603604605",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                }
                );
                s.OwnsOne(s => s.FullName).HasData(
                    new { ServiceRecipientId = 1 ,FirstName = "Robert", LastName = "Laskowski" },
                    new { ServiceRecipientId = 2, FirstName = "Joanna", LastName = "Ferdel" }
                    );
                s.OwnsOne(s => s.Email).HasData(
                    new { ServiceRecipientId = 1, UserName = "rob", DomainName = "dw.pl" },
                    new { ServiceRecipientId = 2, UserName = "asiaf", DomainName = "pkp.pl" }
                    );
            });

            modelBuilder.Entity<PersonPerforming>(s =>
            {
                s.HasData(
                new PersonPerforming()
                {
                    Id = 1,
                    ServiceProviderId = 2,
                    Phone = "200300400",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                },
                new PersonPerforming()
                {
                    Id = 2,
                    ServiceProviderId = 1,
                    Phone = "500666444",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                },
                new PersonPerforming()
                {
                    Id = 3,
                    ServiceProviderId = 1,
                    Phone = "505606707",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                }
                );
                s.OwnsOne(s => s.FullName).HasData(
                    new { PersonPerformingId = 1, FirstName = "Kasia", LastName = "Łaskawa" },
                    new { PersonPerformingId = 2, FirstName = "Janusz", LastName = "Obeznany" },
                    new { PersonPerformingId = 3, FirstName = "Zenon", LastName = "Gruszka" }
                    );
                s.OwnsOne(s => s.Email).HasData(
                    new { PersonPerformingId = 1, UserName = "kaska", DomainName = "op.pl" },
                    new { PersonPerformingId = 2, UserName = "janko", DomainName = "wp.pl" },
                    new { PersonPerformingId = 3, UserName = "zenobio", DomainName = "zix.com" }
                    );
            });

        }
    }
}
