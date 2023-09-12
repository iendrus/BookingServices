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

            modelBuilder.Entity<Provider>(s =>
            {
                s.HasData(
                new Provider()
                {
                    Id = 1,
                    IndustryId = 1,
                    Name = "Prześwietny Salon Art-Design",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true,
                },
                new Provider()
                {
                    Id = 2,
                    IndustryId = 1,
                    Name = "Colormix",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                },
                new Provider()
                {
                    Id = 3,
                    IndustryId = 2,
                    Name = "Śmiechu warte",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                }

                );
                s.OwnsOne(s => s.Email).HasData(
                    new { ProviderId = 1, DomainName = "op.pl", UserName = "art-design" },
                    new { ProviderId = 2, DomainName = "wp.pl", UserName = "color" },
                    new { ProviderId = 3, DomainName = "smiechu.pl", UserName = "warte" }
                    );
                s.OwnsOne(s => s.ContactPerson).HasData(
                    new { ProviderId = 1, FirstName = "Bob", LastName = "Kaminski" },
                    new { ProviderId = 2, FirstName = "Lukas", LastName = "Kolorowy" },
                    new { ProviderId = 3, FirstName = "Anna", LastName = "Zasępiona" }
                    );
                s.OwnsOne(s => s.Address).HasData(
                    new { ProviderId = 1, City = "Dulcza", Street = "Miła", ZipCode ="33-220", Number="14" },
                    new { ProviderId = 2, City = "Flismanowa", ZipCode = "32-120", Number = "234A" },
                    new { ProviderId = 3, City = "Lasków", Street = "Dębowa", ZipCode = "27-100", Number = "22/165" }
                    );
            });

            modelBuilder.Entity<Product>(s =>
            {
                s.HasData(
                new Product()
                {
                    Id = 1,
                    ProviderId = 1,
                    Name = "Idealny Makeup",
                    Description = "Beauty",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                },
                new Product()
                {
                    Id = 2,
                    ProviderId = 1,
                    Name = "Golenie jak złoto",
                    Description = "Bez draśnięcia",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                },
                new Product()
                {
                    Id = 3,
                    ProviderId = 2,
                    Name = "Kolor za zeta",
                    Description = "Będzie Pani zadowolona",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                },
                new Product()
                {
                    Id = 4,
                    ProviderId = 3,
                    Name = "Jazda na całego",
                    Description = "Full wypas",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                })

                ;
            });

            modelBuilder.Entity<Recipient>(s =>
            {
                s.HasData(
                new Recipient()
                {
                    Id = 1,
                    Phone = "500500500",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                },
                new Recipient()
                {
                    Id = 2,
                    Phone = "603604605",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                }
                );
                s.OwnsOne(s => s.FullName).HasData(
                    new { RecipientId = 1 ,FirstName = "Robert", LastName = "Laskowski" },
                    new { RecipientId = 2, FirstName = "Joanna", LastName = "Ferdel" }
                    );
                s.OwnsOne(s => s.Email).HasData(
                    new { RecipientId = 1, UserName = "rob", DomainName = "dw.pl" },
                    new { RecipientId = 2, UserName = "asiaf", DomainName = "pkp.pl" }
                    );
            });

            modelBuilder.Entity<Performer>(s =>
            {
                s.HasData(
                new Performer()
                {
                    Id = 1,
                    ProviderId = 2,
                    Phone = "200300400",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                },
                new Performer()
                {
                    Id = 2,
                    ProviderId = 1,
                    Phone = "500666444",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                },
                new Performer()
                {
                    Id = 3,
                    ProviderId = 1,
                    Phone = "505606707",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                },
                new Performer()
                {
                    Id = 4,
                    ProviderId = 3,
                    Phone = "200300400",
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true
                }
                );
                s.OwnsOne(s => s.FullName).HasData(
                    new { PerformerId = 1, FirstName = "Kasia", LastName = "Łaskawa" },
                    new { PerformerId = 2, FirstName = "Janusz", LastName = "Obeznany" },
                    new { PerformerId = 3, FirstName = "Zenon", LastName = "Gruszka" },
                    new { PerformerId = 4, FirstName = "Stefan", LastName = "Onieśmielający" }
                    );
                s.OwnsOne(s => s.Email).HasData(
                    new { PerformerId = 1, UserName = "kaska", DomainName = "op.pl" },
                    new { PerformerId = 2, UserName = "janko", DomainName = "wp.pl" },
                    new { PerformerId = 3, UserName = "zenobio", DomainName = "zix.com" },
                    new { PerformerId = 4, UserName = "stiwi", DomainName = "smiechu.pl" }
                    );
            });

            modelBuilder.Entity<ProductPerformer>(s =>
            {
                s.HasData(
                new ProductPerformer()
                {
                    PerformerId = 2,
                    ProductId = 1
                },
                new ProductPerformer()
                {
                    PerformerId = 1,
                    ProductId = 3
                },
                new ProductPerformer()
                {
                    PerformerId = 3,
                    ProductId = 2
                },
                new ProductPerformer()
                {
                    PerformerId = 4,
                    ProductId = 4
                })
                ;
            });
        }
    }
}
