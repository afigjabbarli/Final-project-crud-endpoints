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
    [Migration("20240111081802_Seeding initial values to Color table")]
    partial class SeedinginitialvaluestoColortable
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
                            Id = new Guid("03d90fad-8942-4676-ab76-7c43b6d6055f"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Discover cutting-edge smartphones and accessories for seamless connectivity. Elevate your mobile experience with the latest technology, from feature-packed smartphones to stylish and functional accessories that enhance usability and style.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Smartphones and accessories"
                        },
                        new
                        {
                            Id = new Guid("0520912f-21a0-4f9e-9a26-5c961cee1fbd"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Explore the future with smart gadgets. Experience seamless integration of technology into daily life with innovative devices, from smart home solutions to wearables, enhancing convenience, connectivity, and efficiency.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Smart gadgets"
                        },
                        new
                        {
                            Id = new Guid("113c3dfd-e98f-4577-8dcd-26af99dc979a"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Empower your digital journey with notebooks, PCs, and tablets. Find the perfect balance of performance and portability. Choose from a diverse range of computing solutions tailored to your needs.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Notebooks, PCs, tablets"
                        },
                        new
                        {
                            Id = new Guid("07e8daa5-243e-49a4-8d3d-e552848dcc5c"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Products for gamers"
                        },
                        new
                        {
                            Id = new Guid("faae05c6-d8a2-48f3-8a98-8853734e7f8f"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Transform your kitchen with modern convenience. Explore a range of innovative kitchen appliances, from efficient cookware to time-saving gadgets, enhancing your culinary experience with style and functionality.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Kitchen appliances"
                        },
                        new
                        {
                            Id = new Guid("00b61eb9-102f-49ef-8009-3608da1fa75c"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions, making everyday tasks convenient and your living space more comfortable.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Home appliances"
                        },
                        new
                        {
                            Id = new Guid("d186eccf-d2de-4402-a9ce-ac1954bc7f0f"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Discover a world of well-being with beauty and health equipment. From advanced skincare devices to fitness technology, elevate your self-care routine with innovative products designed to promote beauty and wellness.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Beauty and health equipment"
                        },
                        new
                        {
                            Id = new Guid("c8921f52-7cb0-4027-8bd8-b6e22ecb0c0e"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "TV, audio and photo"
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
                            Id = new Guid("ecdafe44-a538-4cac-91c6-462e96b08649"),
                            Color_Code = "#000000",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "black"
                        },
                        new
                        {
                            Id = new Guid("f9bcb956-325a-4e70-bc50-fbfb053a8af0"),
                            Color_Code = "#ffffff",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "white"
                        },
                        new
                        {
                            Id = new Guid("3c4893d0-0e75-4f86-a559-31831113e28f"),
                            Color_Code = "#a52a2a",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "brown"
                        },
                        new
                        {
                            Id = new Guid("8350304e-5ff7-42fd-9708-091d0d444476"),
                            Color_Code = "#0000ff",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "blue"
                        },
                        new
                        {
                            Id = new Guid("57ec16bd-8630-4798-9bad-7658e767f5d4"),
                            Color_Code = "#ff0000",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "red"
                        },
                        new
                        {
                            Id = new Guid("c2b39397-1299-44e4-b499-d513f9f41722"),
                            Color_Code = "#808080",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "gray"
                        },
                        new
                        {
                            Id = new Guid("8cdee5c2-33f1-4eb3-bf3e-74849a096b95"),
                            Color_Code = "#008000",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "green"
                        },
                        new
                        {
                            Id = new Guid("851c3791-ab1c-4dc8-aee6-b06515acaeae"),
                            Color_Code = "#ffff00",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "yellow"
                        },
                        new
                        {
                            Id = new Guid("bfd04d75-2247-4416-b7dc-a64aec14373d"),
                            Color_Code = "#2f4f4f",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "darkslategray"
                        },
                        new
                        {
                            Id = new Guid("9c98f92f-b014-46a0-9bfd-f4324fec5801"),
                            Color_Code = "#663399",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "rebeccapurple"
                        },
                        new
                        {
                            Id = new Guid("54a7408b-2b99-4901-9143-e737ceaf4dc1"),
                            Color_Code = "#ffe4c4",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "bisque"
                        },
                        new
                        {
                            Id = new Guid("145b564f-ec25-4fa7-b0c1-4a331270dba8"),
                            Color_Code = "#ffe4c4",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "bisque"
                        },
                        new
                        {
                            Id = new Guid("14d2bbd9-adc8-492b-ab08-f730414c02dc"),
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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CurrentCategoryId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LastUpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CurrentCategoryId");

                    b.ToTable("Subcategories");
                });

            modelBuilder.Entity("Final_project_crud_endpoints.DataBase.Entities.Subcategory", b =>
                {
                    b.HasOne("Final_project_crud_endpoints.DataBase.Entities.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("CurrentCategoryId")
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