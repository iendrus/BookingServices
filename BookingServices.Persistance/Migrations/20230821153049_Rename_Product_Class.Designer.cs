﻿// <auto-generated />
using System;
using BookingServices.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookingServices.Persistance.Migrations
{
    [DbContext(typeof(BookingServicesDbContext))]
    [Migration("20230821153049_Rename_Product_Class")]
    partial class Rename_Product_Class
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookingServices.Domain.Entities.Industry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Industries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(4257),
                            CreatedBy = 1,
                            Description = "Uroda; Styl życia",
                            IsActive = true,
                            Name = "Beauty"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(4321),
                            CreatedBy = 1,
                            Description = "Rozrywka, zabawa",
                            IsActive = true,
                            Name = "Fun"
                        });
                });

            modelBuilder.Entity("BookingServices.Domain.Entities.PersonPerforming", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ServiceProviderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceProviderId");

                    b.ToTable("PersonPerformings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5776),
                            CreatedBy = 1,
                            IsActive = true,
                            Phone = "200300400",
                            ServiceProviderId = 2
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5788),
                            CreatedBy = 1,
                            IsActive = true,
                            Phone = "500666444",
                            ServiceProviderId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5791),
                            CreatedBy = 1,
                            IsActive = true,
                            Phone = "505606707",
                            ServiceProviderId = 1
                        });
                });

            modelBuilder.Entity("BookingServices.Domain.Entities.ServicePerformance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndOfService")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFinished")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<int>("PersonPerformingId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceProductId")
                        .HasColumnType("int");

                    b.Property<string>("ServiceRecipientComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceRecipientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartOfService")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PersonPerformingId");

                    b.HasIndex("ServiceProductId");

                    b.HasIndex("ServiceRecipientId");

                    b.ToTable("ServicePerformances");
                });

            modelBuilder.Entity("BookingServices.Domain.Entities.ServiceProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceProviderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceProviderId");

                    b.ToTable("ServiceProducts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5374),
                            CreatedBy = 1,
                            Description = "Beauty",
                            IsActive = true,
                            Name = "Idealny Makeup",
                            ServiceProviderId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5388),
                            CreatedBy = 1,
                            Description = "",
                            IsActive = true,
                            Name = "Golenie jak złoto",
                            ServiceProviderId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5392),
                            CreatedBy = 1,
                            Description = "",
                            IsActive = true,
                            Name = "Kolor za zeta",
                            ServiceProviderId = 2
                        });
                });

            modelBuilder.Entity("BookingServices.Domain.Entities.ServiceProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nip")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("IndustryId");

                    b.ToTable("ServiceProviders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(4696),
                            CreatedBy = 1,
                            IndustryId = 1,
                            IsActive = true,
                            Name = "Prześwietny Salon Art-Design"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(4705),
                            CreatedBy = 1,
                            IndustryId = 1,
                            IsActive = true,
                            Name = "Colormix"
                        });
                });

            modelBuilder.Entity("BookingServices.Domain.Entities.ServiceRecipient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("ServiceRecipients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5431),
                            CreatedBy = 1,
                            IsActive = true,
                            Phone = "500500500"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5437),
                            CreatedBy = 1,
                            IsActive = true,
                            Phone = "603604605"
                        });
                });

            modelBuilder.Entity("ServicePersonPerforming", b =>
                {
                    b.Property<int>("PersonPerformingsId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceProductsId")
                        .HasColumnType("int");

                    b.HasKey("PersonPerformingsId", "ServiceProductsId");

                    b.HasIndex("ServiceProductsId");

                    b.ToTable("ServicePersonPerforming");
                });

            modelBuilder.Entity("BookingServices.Domain.Entities.PersonPerforming", b =>
                {
                    b.HasOne("BookingServices.Domain.Entities.ServiceProvider", "ServiceProvider")
                        .WithMany("PersonPerformings")
                        .HasForeignKey("ServiceProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("BookingServices.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<int>("PersonPerformingId")
                                .HasColumnType("int");

                            b1.Property<string>("DomainName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("UserName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.HasKey("PersonPerformingId");

                            b1.ToTable("PersonPerformings");

                            b1.WithOwner()
                                .HasForeignKey("PersonPerformingId");

                            b1.HasData(
                                new
                                {
                                    PersonPerformingId = 1,
                                    DomainName = "op.pl",
                                    UserName = "kaska"
                                },
                                new
                                {
                                    PersonPerformingId = 2,
                                    DomainName = "wp.pl",
                                    UserName = "janko"
                                },
                                new
                                {
                                    PersonPerformingId = 3,
                                    DomainName = "zix.com",
                                    UserName = "zenobio"
                                });
                        });

                    b.OwnsOne("BookingServices.Domain.ValueObjects.PersonName", "FullName", b1 =>
                        {
                            b1.Property<int>("PersonPerformingId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("LastName");

                            b1.HasKey("PersonPerformingId");

                            b1.ToTable("PersonPerformings");

                            b1.WithOwner()
                                .HasForeignKey("PersonPerformingId");

                            b1.HasData(
                                new
                                {
                                    PersonPerformingId = 1,
                                    FirstName = "Kasia",
                                    LastName = "Łaskawa"
                                },
                                new
                                {
                                    PersonPerformingId = 2,
                                    FirstName = "Janusz",
                                    LastName = "Obeznany"
                                },
                                new
                                {
                                    PersonPerformingId = 3,
                                    FirstName = "Zenon",
                                    LastName = "Gruszka"
                                });
                        });

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("FullName")
                        .IsRequired();

                    b.Navigation("ServiceProvider");
                });

            modelBuilder.Entity("BookingServices.Domain.Entities.ServicePerformance", b =>
                {
                    b.HasOne("BookingServices.Domain.Entities.PersonPerforming", "PersonPerforming")
                        .WithMany("ServicePerformances")
                        .HasForeignKey("PersonPerformingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookingServices.Domain.Entities.ServiceProduct", "ServiceProduct")
                        .WithMany("ServicePerformances")
                        .HasForeignKey("ServiceProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BookingServices.Domain.Entities.ServiceRecipient", "ServiceRecipient")
                        .WithMany("ServicePerformances")
                        .HasForeignKey("ServiceRecipientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonPerforming");

                    b.Navigation("ServiceProduct");

                    b.Navigation("ServiceRecipient");
                });

            modelBuilder.Entity("BookingServices.Domain.Entities.ServiceProduct", b =>
                {
                    b.HasOne("BookingServices.Domain.Entities.ServiceProvider", "ServiceProvider")
                        .WithMany("ServiceProducts")
                        .HasForeignKey("ServiceProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServiceProvider");
                });

            modelBuilder.Entity("BookingServices.Domain.Entities.ServiceProvider", b =>
                {
                    b.HasOne("BookingServices.Domain.Entities.Industry", "Industry")
                        .WithMany("ServiceProviders")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("BookingServices.Domain.ValueObjects.PersonName", "ContactPerson", b1 =>
                        {
                            b1.Property<int>("ServiceProviderId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("LastName");

                            b1.HasKey("ServiceProviderId");

                            b1.ToTable("ServiceProviders");

                            b1.WithOwner()
                                .HasForeignKey("ServiceProviderId");

                            b1.HasData(
                                new
                                {
                                    ServiceProviderId = 1,
                                    FirstName = "Bob",
                                    LastName = "Kaminski"
                                },
                                new
                                {
                                    ServiceProviderId = 2,
                                    FirstName = "Lukas",
                                    LastName = "Kolorowy"
                                });
                        });

                    b.OwnsOne("BookingServices.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<int>("ServiceProviderId")
                                .HasColumnType("int");

                            b1.Property<string>("DomainName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("UserName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.HasKey("ServiceProviderId");

                            b1.ToTable("ServiceProviders");

                            b1.WithOwner()
                                .HasForeignKey("ServiceProviderId");

                            b1.HasData(
                                new
                                {
                                    ServiceProviderId = 1,
                                    DomainName = "op.pl",
                                    UserName = "art-design"
                                },
                                new
                                {
                                    ServiceProviderId = 2,
                                    DomainName = "wp.pl",
                                    UserName = "color"
                                });
                        });

                    b.OwnsOne("BookingServices.Domain.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<int>("ServiceProviderId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("City");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasMaxLength(10)
                                .HasColumnType("nvarchar(10)")
                                .HasColumnName("Number");

                            b1.Property<string>("Street")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Street");

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasMaxLength(10)
                                .HasColumnType("nvarchar(10)")
                                .HasColumnName("ZipCode");

                            b1.HasKey("ServiceProviderId");

                            b1.ToTable("ServiceProviders");

                            b1.WithOwner()
                                .HasForeignKey("ServiceProviderId");

                            b1.HasData(
                                new
                                {
                                    ServiceProviderId = 1,
                                    City = "Dulcza",
                                    Number = "14",
                                    Street = "Miła",
                                    ZipCode = "33-220"
                                },
                                new
                                {
                                    ServiceProviderId = 2,
                                    City = "Flismanowa",
                                    Number = "234A",
                                    ZipCode = "32-120"
                                });
                        });

                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("ContactPerson")
                        .IsRequired();

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("Industry");
                });

            modelBuilder.Entity("BookingServices.Domain.Entities.ServiceRecipient", b =>
                {
                    b.OwnsOne("BookingServices.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<int>("ServiceRecipientId")
                                .HasColumnType("int");

                            b1.Property<string>("DomainName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("UserName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.HasKey("ServiceRecipientId");

                            b1.ToTable("ServiceRecipients");

                            b1.WithOwner()
                                .HasForeignKey("ServiceRecipientId");

                            b1.HasData(
                                new
                                {
                                    ServiceRecipientId = 1,
                                    DomainName = "dw.pl",
                                    UserName = "rob"
                                },
                                new
                                {
                                    ServiceRecipientId = 2,
                                    DomainName = "pkp.pl",
                                    UserName = "asiaf"
                                });
                        });

                    b.OwnsOne("BookingServices.Domain.ValueObjects.PersonName", "FullName", b1 =>
                        {
                            b1.Property<int>("ServiceRecipientId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("LastName");

                            b1.HasKey("ServiceRecipientId");

                            b1.ToTable("ServiceRecipients");

                            b1.WithOwner()
                                .HasForeignKey("ServiceRecipientId");

                            b1.HasData(
                                new
                                {
                                    ServiceRecipientId = 1,
                                    FirstName = "Robert",
                                    LastName = "Laskowski"
                                },
                                new
                                {
                                    ServiceRecipientId = 2,
                                    FirstName = "Joanna",
                                    LastName = "Ferdel"
                                });
                        });

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("FullName")
                        .IsRequired();
                });

            modelBuilder.Entity("ServicePersonPerforming", b =>
                {
                    b.HasOne("BookingServices.Domain.Entities.PersonPerforming", null)
                        .WithMany()
                        .HasForeignKey("PersonPerformingsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BookingServices.Domain.Entities.ServiceProduct", null)
                        .WithMany()
                        .HasForeignKey("ServiceProductsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("BookingServices.Domain.Entities.Industry", b =>
                {
                    b.Navigation("ServiceProviders");
                });

            modelBuilder.Entity("BookingServices.Domain.Entities.PersonPerforming", b =>
                {
                    b.Navigation("ServicePerformances");
                });

            modelBuilder.Entity("BookingServices.Domain.Entities.ServiceProduct", b =>
                {
                    b.Navigation("ServicePerformances");
                });

            modelBuilder.Entity("BookingServices.Domain.Entities.ServiceProvider", b =>
                {
                    b.Navigation("PersonPerformings");

                    b.Navigation("ServiceProducts");
                });

            modelBuilder.Entity("BookingServices.Domain.Entities.ServiceRecipient", b =>
                {
                    b.Navigation("ServicePerformances");
                });
#pragma warning restore 612, 618
        }
    }
}
