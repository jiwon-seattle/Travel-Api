﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    [Migration("20200331221932_AddOverallRating")]
    partial class AddOverallRating
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityName")
                        .IsRequired();

                    b.Property<int>("CountryId");

                    b.Property<double>("OverallRating");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CityName = "Seoul",
                            CountryId = 1,
                            OverallRating = 0.0
                        },
                        new
                        {
                            CityId = 2,
                            CityName = "Shanghai",
                            CountryId = 2,
                            OverallRating = 0.0
                        },
                        new
                        {
                            CityId = 3,
                            CityName = "Singapore",
                            CountryId = 3,
                            OverallRating = 0.0
                        },
                        new
                        {
                            CityId = 4,
                            CityName = "Paris",
                            CountryId = 4,
                            OverallRating = 0.0
                        },
                        new
                        {
                            CityId = 5,
                            CityName = "Moscow",
                            CountryId = 5,
                            OverallRating = 0.0
                        },
                        new
                        {
                            CityId = 6,
                            CityName = "Beijing",
                            CountryId = 2,
                            OverallRating = 0.0
                        });
                });

            modelBuilder.Entity("TravelApi.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryName")
                        .IsRequired();

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "Korea"
                        },
                        new
                        {
                            CountryId = 2,
                            CountryName = "China"
                        },
                        new
                        {
                            CountryId = 3,
                            CountryName = "Singapore"
                        },
                        new
                        {
                            CountryId = 4,
                            CountryName = "France"
                        },
                        new
                        {
                            CountryId = 5,
                            CountryName = "Russia"
                        });
                });

            modelBuilder.Entity("TravelApi.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityId");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<int?>("CountryId");

                    b.Property<DateTime>("Date");

                    b.Property<double>("Rating");

                    b.Property<string>("Title");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("ReviewId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            CityId = 1,
                            Content = "People are awake until late at night. Drinking is must-do thing",
                            Date = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 5.0,
                            Title = "Amazing Night Culture",
                            UserName = "Emily"
                        },
                        new
                        {
                            ReviewId = 2,
                            CityId = 2,
                            Content = "Very modern city with busy but nice people",
                            Date = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 5.0,
                            Title = "Modern City",
                            UserName = "Justin"
                        },
                        new
                        {
                            ReviewId = 3,
                            CityId = 3,
                            Content = "Clean and mix of culture",
                            Date = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 3.0,
                            Title = "Most clean country in the world",
                            UserName = "Tim"
                        },
                        new
                        {
                            ReviewId = 4,
                            CityId = 4,
                            Content = "In the morning, I can start my day with smell of bakeries in the street.",
                            Date = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 3.0,
                            Title = "Good Bakeries everywhere!",
                            UserName = "Angela"
                        },
                        new
                        {
                            ReviewId = 5,
                            CityId = 5,
                            Content = "Freezing outside. But it is worth visiting for sure",
                            Date = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 3.0,
                            Title = "Very Cold!",
                            UserName = "Kim"
                        },
                        new
                        {
                            ReviewId = 6,
                            CityId = 4,
                            Content = "Really enjoyed seeing the Eiffel Tower and Louve",
                            Date = new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 4.0,
                            Title = "Museums and the Eiffel Tower",
                            UserName = "Mari"
                        },
                        new
                        {
                            ReviewId = 7,
                            CityId = 6,
                            Content = "Very large and very crowded",
                            Date = new DateTime(2020, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 2.0,
                            Title = "Forbidden City",
                            UserName = "Mari"
                        });
                });

            modelBuilder.Entity("TravelApi.Models.City", b =>
                {
                    b.HasOne("TravelApi.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelApi.Models.Review", b =>
                {
                    b.HasOne("TravelApi.Models.City", "City")
                        .WithMany("Reviews")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelApi.Models.Country")
                        .WithMany("Reviews")
                        .HasForeignKey("CountryId");
                });
#pragma warning restore 612, 618
        }
    }
}
