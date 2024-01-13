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
    [Migration("20240111104626_test 1")]
    partial class test1
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
                            Id = new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Discover cutting-edge smartphones and accessories for seamless connectivity. Elevate your mobile experience with the latest technology, from feature-packed smartphones to stylish and functional accessories that enhance usability and style.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Smartphones and accessories"
                        },
                        new
                        {
                            Id = new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Explore the future with smart gadgets. Experience seamless integration of technology into daily life with innovative devices, from smart home solutions to wearables, enhancing convenience, connectivity, and efficiency.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Smart gadgets"
                        },
                        new
                        {
                            Id = new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Empower your digital journey with notebooks, PCs, and tablets. Find the perfect balance of performance and portability. Choose from a diverse range of computing solutions tailored to your needs.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Notebooks, PCs, tablets"
                        },
                        new
                        {
                            Id = new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Products for gamers"
                        },
                        new
                        {
                            Id = new Guid("f6b3406c-6046-486f-8ba8-a896ac26fe90"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Transform your kitchen with modern convenience. Explore a range of innovative kitchen appliances, from efficient cookware to time-saving gadgets, enhancing your culinary experience with style and functionality.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Kitchen appliances"
                        },
                        new
                        {
                            Id = new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions, making everyday tasks convenient and your living space more comfortable.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Home appliances"
                        },
                        new
                        {
                            Id = new Guid("d2bc155a-9de0-40ed-b3e7-1a4c0983c2e5"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Discover a world of well-being with beauty and health equipment. From advanced skincare devices to fitness technology, elevate your self-care routine with innovative products designed to promote beauty and wellness.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Beauty and health equipment"
                        },
                        new
                        {
                            Id = new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "TV, audio and photo"
                        },
                        new
                        {
                            Id = new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Hobby and entertainment"
                        },
                        new
                        {
                            Id = new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Construction supplies"
                        },
                        new
                        {
                            Id = new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Automotive products"
                        },
                        new
                        {
                            Id = new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"),
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
                            Id = new Guid("4b24804b-9a8f-4d33-9f43-8c461e4dbf11"),
                            Color_Code = "#000000",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "black"
                        },
                        new
                        {
                            Id = new Guid("9c327764-bf90-4b8b-8c38-370cb3aa2a5a"),
                            Color_Code = "#ffffff",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "white"
                        },
                        new
                        {
                            Id = new Guid("8a4c94f8-2437-4e89-9075-56bbcf19c0e9"),
                            Color_Code = "#a52a2a",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "brown"
                        },
                        new
                        {
                            Id = new Guid("af15118a-95ac-487a-b103-c9a0a1918c25"),
                            Color_Code = "#0000ff",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "blue"
                        },
                        new
                        {
                            Id = new Guid("6c1d50fc-b6eb-4d76-ba7e-81a7811ea15f"),
                            Color_Code = "#ff0000",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "red"
                        },
                        new
                        {
                            Id = new Guid("3e20ac3a-c156-4f60-b0b4-e1f1c205e24d"),
                            Color_Code = "#808080",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "gray"
                        },
                        new
                        {
                            Id = new Guid("db1ef4d9-5b95-41a3-8bfb-7f01f8a50f32"),
                            Color_Code = "#008000",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "green"
                        },
                        new
                        {
                            Id = new Guid("45e0cbf9-aa2a-44a4-93a1-bf4d3aa623ce"),
                            Color_Code = "#ffff00",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "yellow"
                        },
                        new
                        {
                            Id = new Guid("8640c057-8997-4b16-b3dd-7c3d3c2e1a12"),
                            Color_Code = "#2f4f4f",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "darkslategray"
                        },
                        new
                        {
                            Id = new Guid("7a9d04e8-1a22-4aae-8232-62f5a0c28b87"),
                            Color_Code = "#663399",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "rebeccapurple"
                        },
                        new
                        {
                            Id = new Guid("2ff83d6b-6c95-4f7d-9c64-60e406a057a1"),
                            Color_Code = "#ffe4c4",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "bisque"
                        },
                        new
                        {
                            Id = new Guid("9a305d7f-5c8f-4fe1-9c0d-d8a8eb4a17c3"),
                            Color_Code = "#ffe4c4",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "bisque"
                        },
                        new
                        {
                            Id = new Guid("c80a742d-12db-4a19-a0e8-44c67f7fb21a"),
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

                    b.Property<Guid>("Current_Category_Id")
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

                    b.HasIndex("Current_Category_Id");

                    b.ToTable("Subcategories");
                });

            modelBuilder.Entity("Final_project_crud_endpoints.DataBase.Entities.Subcategory", b =>
                {
                    b.HasOne("Final_project_crud_endpoints.DataBase.Entities.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("Current_Category_Id")
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