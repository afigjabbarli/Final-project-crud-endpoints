﻿// <auto-generated />
using System;
using Final_project_crud_endpoints.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240111101834_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Final_project_crud_endpoints.DataBase.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LastUpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f902d97c-953c-433d-a397-63516d9bdf1d"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Discover cutting-edge smartphones and accessories for seamless connectivity. Elevate your mobile experience with the latest technology, from feature-packed smartphones to stylish and functional accessories that enhance usability and style.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Smartphones and accessories"
                        },
                        new
                        {
                            Id = new Guid("39f6fdc5-45e1-4b92-9383-8e1c1d98f7ea"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Explore the future with smart gadgets. Experience seamless integration of technology into daily life with innovative devices, from smart home solutions to wearables, enhancing convenience, connectivity, and efficiency.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Smart gadgets"
                        },
                        new
                        {
                            Id = new Guid("95be74c0-4536-418e-af2f-6d5e5e0fd8ea"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Empower your digital journey with notebooks, PCs, and tablets. Find the perfect balance of performance and portability. Choose from a diverse range of computing solutions tailored to your needs.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Notebooks, PCs, tablets"
                        },
                        new
                        {
                            Id = new Guid("77be8093-01e1-4ce5-a8af-d1ac806142d4"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Products for gamers"
                        },
                        new
                        {
                            Id = new Guid("73643a09-4bf1-41a3-afd1-eb5a1c9d64f9"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Transform your kitchen with modern convenience. Explore a range of innovative kitchen appliances, from efficient cookware to time-saving gadgets, enhancing your culinary experience with style and functionality.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Kitchen appliances"
                        },
                        new
                        {
                            Id = new Guid("10f780c2-7abc-41d1-bee5-8334d9ec55c5"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions, making everyday tasks convenient and your living space more comfortable.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Home appliances"
                        },
                        new
                        {
                            Id = new Guid("b92a1575-40df-4b21-b354-28b7d2369987"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Discover a world of well-being with beauty and health equipment. From advanced skincare devices to fitness technology, elevate your self-care routine with innovative products designed to promote beauty and wellness.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Beauty and health equipment"
                        },
                        new
                        {
                            Id = new Guid("9ad2cd64-2820-4e7c-892b-d853a7616185"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "TV, audio and photo"
                        },
                        new
                        {
                            Id = new Guid("48d9e9ed-e79e-4b13-ba90-516995feb7c8"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Hobby and entertainment"
                        },
                        new
                        {
                            Id = new Guid("90d88eb0-ad08-434e-a474-e2d98d10ebe0"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Construction supplies"
                        },
                        new
                        {
                            Id = new Guid("4e3bdb6a-1631-472b-8e0f-4353e3fa2827"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Automotive products"
                        },
                        new
                        {
                            Id = new Guid("7ccd4698-0b6e-479a-a47d-cf13f0917e14"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions, making everyday tasks convenient and your living space more comfortable.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "House and garden"
                        });
                });

            modelBuilder.Entity("Final_project_crud_endpoints.DataBase.Entities.Color", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Color_Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("LastUpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Color");

                    b.HasData(
                        new
                        {
                            Id = new Guid("41b2e6c8-8384-40f4-99a7-6a8189d1ca30"),
                            Color_Code = "#000000",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "black"
                        },
                        new
                        {
                            Id = new Guid("932a00b8-2f86-40d4-8c41-41293c1d4d7e"),
                            Color_Code = "#ffffff",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "white"
                        },
                        new
                        {
                            Id = new Guid("dde641a4-1057-49b4-be2b-5501d387b4b0"),
                            Color_Code = "#a52a2a",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "brown"
                        },
                        new
                        {
                            Id = new Guid("1ea9c1f3-e58a-46a9-a13b-a1ba54efa3cf"),
                            Color_Code = "#0000ff",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "blue"
                        },
                        new
                        {
                            Id = new Guid("84b1c949-c7f8-443f-8ef5-c428bee4a64a"),
                            Color_Code = "#ff0000",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "red"
                        },
                        new
                        {
                            Id = new Guid("9de721a3-70a7-4e8e-82ff-df7a8d37223e"),
                            Color_Code = "#808080",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "gray"
                        },
                        new
                        {
                            Id = new Guid("51fe3065-dd8a-4e93-b73e-53a4d103c7f5"),
                            Color_Code = "#008000",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "green"
                        },
                        new
                        {
                            Id = new Guid("d21b6c6e-32cc-4181-ae9f-5b8a75f11da0"),
                            Color_Code = "#ffff00",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "yellow"
                        },
                        new
                        {
                            Id = new Guid("2ab2d708-7a28-4374-a8bd-ed614a784b96"),
                            Color_Code = "#2f4f4f",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "darkslategray"
                        },
                        new
                        {
                            Id = new Guid("44f6625a-ee67-4104-a1e0-45f487c422fb"),
                            Color_Code = "#663399",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "rebeccapurple"
                        },
                        new
                        {
                            Id = new Guid("80b4e790-f40f-41fa-bb21-eec6ccd827d9"),
                            Color_Code = "#ffe4c4",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "bisque"
                        },
                        new
                        {
                            Id = new Guid("b1363337-95b6-4e97-b007-5142a39d26b5"),
                            Color_Code = "#ffe4c4",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "bisque"
                        },
                        new
                        {
                            Id = new Guid("30545496-b78d-4280-8cb0-316a6f0bb06e"),
                            Color_Code = "#00ced1",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "darkturquoise"
                        });
                });

            modelBuilder.Entity("Final_project_crud_endpoints.DataBase.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Discount")
                        .HasColumnType("integer");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsOffer")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastUpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ManufacturedIn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric");

                    b.Property<string>("TrackingCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Final_project_crud_endpoints.DataBase.Entities.Subcategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LastUpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategories");
                });

            modelBuilder.Entity("Final_project_crud_endpoints.DataBase.Entities.Subcategory", b =>
                {
                    b.HasOne("Final_project_crud_endpoints.DataBase.Entities.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Final_project_crud_endpoints.DataBase.Entities.Category", b =>
                {
                    b.Navigation("Subcategories");
                });
#pragma warning restore 612, 618
        }
    }
}