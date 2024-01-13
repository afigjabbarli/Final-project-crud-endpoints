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
    [Migration("20240111095522_latest changes")]
    partial class latestchanges
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
                            Id = new Guid("e4606ae9-4c1e-4b26-b9c2-9328cf07edcd"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Discover cutting-edge smartphones and accessories for seamless connectivity. Elevate your mobile experience with the latest technology, from feature-packed smartphones to stylish and functional accessories that enhance usability and style.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Smartphones and accessories"
                        },
                        new
                        {
                            Id = new Guid("c1638140-814b-43de-aed3-8b3b00c1ab8e"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Explore the future with smart gadgets. Experience seamless integration of technology into daily life with innovative devices, from smart home solutions to wearables, enhancing convenience, connectivity, and efficiency.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Smart gadgets"
                        },
                        new
                        {
                            Id = new Guid("4d209225-2a50-4d15-9ec2-23877ae3deb2"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Empower your digital journey with notebooks, PCs, and tablets. Find the perfect balance of performance and portability. Choose from a diverse range of computing solutions tailored to your needs.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Notebooks, PCs, tablets"
                        },
                        new
                        {
                            Id = new Guid("4de817e5-728f-4a81-8ceb-1956b7b21c23"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Products for gamers"
                        },
                        new
                        {
                            Id = new Guid("9a7c6a18-53ea-4461-aeac-a881298da985"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Transform your kitchen with modern convenience. Explore a range of innovative kitchen appliances, from efficient cookware to time-saving gadgets, enhancing your culinary experience with style and functionality.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Kitchen appliances"
                        },
                        new
                        {
                            Id = new Guid("39c12978-e6b2-4470-a1e7-736ac74e7767"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions, making everyday tasks convenient and your living space more comfortable.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Home appliances"
                        },
                        new
                        {
                            Id = new Guid("19bf52fc-2fa4-4944-a9ab-ccfc70d1f486"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Discover a world of well-being with beauty and health equipment. From advanced skincare devices to fitness technology, elevate your self-care routine with innovative products designed to promote beauty and wellness.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Beauty and health equipment"
                        },
                        new
                        {
                            Id = new Guid("fd32eb04-5eab-496f-8101-50871336172a"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "TV, audio and photo"
                        },
                        new
                        {
                            Id = new Guid("1461fc5f-46f5-42d8-8e50-962297f85772"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Hobby and entertainment"
                        },
                        new
                        {
                            Id = new Guid("32a488a4-d88c-488f-a1f3-8f27dfdd3e6d"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Construction supplies"
                        },
                        new
                        {
                            Id = new Guid("158ffdf0-9af6-476c-8f25-45a29886703b"),
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.",
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Automotive products"
                        },
                        new
                        {
                            Id = new Guid("43d6a5dc-2ff9-4ff2-bd8b-e8e1651fd86e"),
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
                            Id = new Guid("32dff4b9-0d0b-4395-b929-1d8791463d7c"),
                            Color_Code = "#000000",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "black"
                        },
                        new
                        {
                            Id = new Guid("3e2f5718-007a-4301-bfe9-211d58cdda19"),
                            Color_Code = "#ffffff",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "white"
                        },
                        new
                        {
                            Id = new Guid("95795514-3200-44b5-a1a3-8a4dbc15ceb6"),
                            Color_Code = "#a52a2a",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "brown"
                        },
                        new
                        {
                            Id = new Guid("3c2ccb9d-1342-4824-965c-f52fb6637113"),
                            Color_Code = "#0000ff",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "blue"
                        },
                        new
                        {
                            Id = new Guid("597695df-82b6-46f1-9e71-1cdd6d0341ba"),
                            Color_Code = "#ff0000",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "red"
                        },
                        new
                        {
                            Id = new Guid("92c6cbab-366e-4df4-9f09-48aa7725ef20"),
                            Color_Code = "#808080",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "gray"
                        },
                        new
                        {
                            Id = new Guid("6e6ed80a-b0c2-474f-a65b-01ebe57f5d65"),
                            Color_Code = "#008000",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "green"
                        },
                        new
                        {
                            Id = new Guid("c46399f0-db2b-4c3f-99be-a5ddd0d643b8"),
                            Color_Code = "#ffff00",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "yellow"
                        },
                        new
                        {
                            Id = new Guid("973a298b-b70e-4132-9784-2659d7bbdc0a"),
                            Color_Code = "#2f4f4f",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "darkslategray"
                        },
                        new
                        {
                            Id = new Guid("74423ff2-c71a-4358-86f8-954f2a5ee99b"),
                            Color_Code = "#663399",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "rebeccapurple"
                        },
                        new
                        {
                            Id = new Guid("2c887422-582e-43f2-90db-547b3a268116"),
                            Color_Code = "#ffe4c4",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "bisque"
                        },
                        new
                        {
                            Id = new Guid("1dcf5e26-86d5-4071-8d56-75e2544de4ee"),
                            Color_Code = "#ffe4c4",
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "bisque"
                        },
                        new
                        {
                            Id = new Guid("c0f96038-3f49-4979-aefe-d17ad3fa68ba"),
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