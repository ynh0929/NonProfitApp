﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NonProfitLibrary.Data;

#nullable disable

namespace NonProfitLibrary.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231123225820_M1")]
    partial class M1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "b1b2a3f8-4128-4393-acd6-aefb79111ab6",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "5411512a-393f-4ac5-a269-2cafe028f269",
                            Name = "Finance",
                            NormalizedName = "FINANCE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "3a58ee77-88d7-49fd-9bbc-7ad92d0e8fa1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "82b00b2f-e341-4483-a426-bfd703cc859c",
                            Email = "a@a.a",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "A@A.A",
                            NormalizedUserName = "A@A.A",
                            PasswordHash = "AQAAAAIAAYagAAAAEJB2yf/l6QnAzc7N/+/cQ8r9PG6xLAWV1cnNJsy4e2we3hO3DhtgN/aBkT8JOdD+Ow==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a1e3cd67-8296-45a8-8ea7-760d0fd619ad",
                            TwoFactorEnabled = false,
                            UserName = "a@a.a"
                        },
                        new
                        {
                            Id = "4aa7fb80-1f2a-415e-807d-da70bc9d9d43",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "831b57e7-fb5c-4eca-90b3-bcedf9286e37",
                            Email = "f@f.f",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "F@F.F",
                            NormalizedUserName = "F@F.F",
                            PasswordHash = "AQAAAAIAAYagAAAAENY6IMQMBZ9MCjGHvYi7Rezf5WM5+M0UfiDqsr+LhdMrTC9/M4chXvutW2Qz2GdO3A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1f70fcce-884f-4b00-a1f7-034402a603fe",
                            TwoFactorEnabled = false,
                            UserName = "f@f.f"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "3a58ee77-88d7-49fd-9bbc-7ad92d0e8fa1",
                            RoleId = "b1b2a3f8-4128-4393-acd6-aefb79111ab6"
                        },
                        new
                        {
                            UserId = "4aa7fb80-1f2a-415e-807d-da70bc9d9d43",
                            RoleId = "5411512a-393f-4ac5-a269-2cafe028f269"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("NonProfitLibrary.ContactList", b =>
                {
                    b.Property<int>("AccountNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccountNo");

                    b.ToTable("ContactLists");

                    b.HasData(
                        new
                        {
                            AccountNo = 12,
                            City = "Richmond",
                            Country = "Canada",
                            Created = new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6877),
                            CreatedBy = "System",
                            Email = "sam@fox.com",
                            FirstName = "Sam",
                            LastName = "Fox",
                            Modified = new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6880),
                            ModifiedBy = "System",
                            PostalCode = "V4F 1M7",
                            Street = "457 Fox Avenue"
                        },
                        new
                        {
                            AccountNo = 17,
                            City = "Delta",
                            Country = "Canada",
                            Created = new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6927),
                            CreatedBy = "System",
                            Email = "ann@day.com",
                            FirstName = "Ann",
                            LastName = "Day",
                            Modified = new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6927),
                            ModifiedBy = "System",
                            PostalCode = "V6G 1M6",
                            Street = "231 River Road"
                        },
                        new
                        {
                            AccountNo = 25,
                            City = "Vancouver",
                            Country = "Canada",
                            Created = new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6950),
                            CreatedBy = "System",
                            Email = "john@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Modified = new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6951),
                            ModifiedBy = "System",
                            PostalCode = "V5G 1H6",
                            Street = "123 Main Street"
                        },
                        new
                        {
                            AccountNo = 29,
                            City = "Vancouver",
                            Country = "Canada",
                            Created = new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6965),
                            CreatedBy = "System",
                            Email = "jane@ex.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Modified = new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6965),
                            ModifiedBy = "System",
                            PostalCode = "V3G 1K6",
                            Street = "456 Oak Street"
                        });
                });

            modelBuilder.Entity("NonProfitLibrary.Donation", b =>
                {
                    b.Property<int>("TransId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountNo")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Amount")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TransactionTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TransId");

                    b.HasIndex("AccountNo");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("Donations");

                    b.HasData(
                        new
                        {
                            TransId = 1,
                            AccountNo = 12,
                            Amount = 100f,
                            Created = new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7418),
                            CreatedBy = "System",
                            Date = new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7420),
                            ModifiedBy = "System",
                            Notes = "Test1",
                            PaymentMethodId = 4,
                            TransactionTypeId = 3
                        },
                        new
                        {
                            TransId = 2,
                            AccountNo = 17,
                            Amount = 50f,
                            Created = new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7467),
                            CreatedBy = "System",
                            Date = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7467),
                            ModifiedBy = "System",
                            Notes = "Test2",
                            PaymentMethodId = 3,
                            TransactionTypeId = 2
                        },
                        new
                        {
                            TransId = 3,
                            AccountNo = 25,
                            Amount = 250f,
                            Created = new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7486),
                            CreatedBy = "System",
                            Date = new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7486),
                            ModifiedBy = "System",
                            Notes = "Test3",
                            PaymentMethodId = 2,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            TransId = 4,
                            AccountNo = 29,
                            Amount = 1000f,
                            Created = new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7501),
                            CreatedBy = "System",
                            Date = new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7501),
                            ModifiedBy = "System",
                            Notes = "Test4",
                            PaymentMethodId = 1,
                            TransactionTypeId = 1
                        });
                });

            modelBuilder.Entity("NonProfitLibrary.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PaymentMethodId");

                    b.ToTable("PaymentMethods");

                    b.HasData(
                        new
                        {
                            PaymentMethodId = 1,
                            Created = new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(198),
                            CreatedBy = "System",
                            Modified = new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(199),
                            ModifiedBy = "System",
                            Name = "Direct Deposit"
                        },
                        new
                        {
                            PaymentMethodId = 2,
                            Created = new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(247),
                            CreatedBy = "System",
                            Modified = new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(248),
                            ModifiedBy = "System",
                            Name = "PayPal"
                        },
                        new
                        {
                            PaymentMethodId = 3,
                            Created = new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(260),
                            CreatedBy = "System",
                            Modified = new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(261),
                            ModifiedBy = "System",
                            Name = "Check"
                        },
                        new
                        {
                            PaymentMethodId = 4,
                            Created = new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(269),
                            CreatedBy = "System",
                            Modified = new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(269),
                            ModifiedBy = "System",
                            Name = "Cash"
                        });
                });

            modelBuilder.Entity("NonProfitLibrary.TransactionType", b =>
                {
                    b.Property<int>("TransactionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TransactionTypeId");

                    b.ToTable("TransactionTypes");

                    b.HasData(
                        new
                        {
                            TransactionTypeId = 1,
                            Created = new DateTime(2023, 11, 23, 22, 58, 20, 92, DateTimeKind.Utc).AddTicks(9061),
                            CreatedBy = "System",
                            Description = "Donations made without any special purpose",
                            Modified = new DateTime(2023, 11, 23, 22, 58, 20, 92, DateTimeKind.Utc).AddTicks(9062),
                            ModifiedBy = "System",
                            Name = "General Donation"
                        },
                        new
                        {
                            TransactionTypeId = 2,
                            Created = new DateTime(2023, 11, 23, 22, 58, 20, 92, DateTimeKind.Utc).AddTicks(9137),
                            CreatedBy = "System",
                            Description = "Donations made for homeless people",
                            Modified = new DateTime(2023, 11, 23, 22, 58, 20, 92, DateTimeKind.Utc).AddTicks(9137),
                            ModifiedBy = "System",
                            Name = "Food for homeless"
                        },
                        new
                        {
                            TransactionTypeId = 3,
                            Created = new DateTime(2023, 11, 23, 22, 58, 20, 92, DateTimeKind.Utc).AddTicks(9152),
                            CreatedBy = "System",
                            Description = "Donations for the purpose of upgrading the gym",
                            Modified = new DateTime(2023, 11, 23, 22, 58, 20, 92, DateTimeKind.Utc).AddTicks(9152),
                            ModifiedBy = "System",
                            Name = "Repair of Gym"
                        });
                });

            modelBuilder.Entity("NonProfitLibrary.Donation", b =>
                {
                    b.HasOne("NonProfitLibrary.ContactList", null)
                        .WithMany()
                        .HasForeignKey("AccountNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NonProfitLibrary.PaymentMethod", null)
                        .WithMany()
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NonProfitLibrary.TransactionType", null)
                        .WithMany()
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
