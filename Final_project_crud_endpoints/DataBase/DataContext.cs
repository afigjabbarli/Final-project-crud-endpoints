using Final_project_crud_endpoints.DataBase.Entities;
using Final_project_crud_endpoints.DataBase.Entities.Identity;
using Microsoft.EntityFrameworkCore;

namespace Final_project_crud_endpoints.DataBase
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //One to many relationship between sategory and subcategory

            modelBuilder.Entity<Subcategory>()
                .HasOne<Category>(sc => sc.Category)
                .WithMany(c => c.Subcategories)
                .HasForeignKey(sc => sc.Current_Category_Id);

            //One to many relationship between sategory and subcategory

            //One to many relationship between user and email

            modelBuilder.Entity<Email>()
               .HasOne<User>(e => e.User)
               .WithMany(u => u.Emails)
               .HasForeignKey(e => e.UserId);

            //One to many relationship between user and email

            //One to many relationship between subcategory and deepcategory

            modelBuilder.Entity<Deepcategory>()
                .HasOne<Subcategory>(dc => dc.Subcategory)
                .WithMany(sc => sc.Deepcategories)
                .HasForeignKey(dc => dc.Current_Subcategory_Id);

            //One to many relationship between subcategory and deepcategory

            //One to one relationship between user and activation token

            modelBuilder.Entity<User>()
                .HasOne<ActivationToken>(u => u.ActivationToken)
                .WithOne(act => act.User)
                .HasForeignKey<ActivationToken>(act => act.UserId);

            //One to one relationship between user and activation token

            //One to many relationship between deepcategory and product

            modelBuilder.Entity<Product>()
                .HasOne<Deepcategory>(p => p.Deepcategory)
                .WithMany(dc => dc.Products)
                .HasForeignKey(p => p.Current_Deepcategory_Id);

            //One to many relationship between deepcategory and product

            //One to many relationship between brand and product

            modelBuilder.Entity<Product>()
                .HasOne<Brand>(p => p.Brand)
                .WithMany(br => br.Products)
                .HasForeignKey(p => p.Current_Brand_Id);

            //One to many relationship between brand and product

            //Many to many relationship between store and product

            modelBuilder.Entity<ProductStore>().HasKey(ps => new { ps.Product_Id, ps.Store_Id });

            modelBuilder.Entity<ProductStore>()
                .HasOne<Product>(ps => ps.Product)
                .WithMany(p => p.ProductStores)
                .HasForeignKey(ps => ps.Product_Id);


            modelBuilder.Entity<ProductStore>()
                .HasOne<Store>(ps => ps.Store)
                .WithMany(s => s.ProductStores)
                .HasForeignKey(ps => ps.Store_Id);

            //Many to many relationship between store and product

            //Many to many relationship between size and product

            modelBuilder.Entity<ProductSize>().HasKey(ps => new { ps.Product_Id, ps.Size_Id });

            modelBuilder.Entity<ProductSize>()
                .HasOne<Product>(ps => ps.Product)
                .WithMany(p => p.ProductSizes)
                .HasForeignKey(ps => ps.Product_Id);


            modelBuilder.Entity<ProductSize>()
                .HasOne<Size>(ps => ps.Size)
                .WithMany(s => s.ProductSizes)
                .HasForeignKey(ps => ps.Size_Id);

            //Many to many relationship between size and product

            //Many to many relationship between color and product

            modelBuilder.Entity<ProductColor>().HasKey(pc => new { pc.Product_Id, pc.Color_Id });

            modelBuilder.Entity<ProductColor>()
                .HasOne<Product>(pc => pc.Product)
                .WithMany(p => p.ProductColors)
                .HasForeignKey(pc => pc.Product_Id);

            modelBuilder.Entity<ProductColor>()
                .HasOne<Color>(pc => pc.Color)
                .WithMany(c => c.ProductColors)
                .HasForeignKey(pc => pc.Color_Id);

            //Many to many relationship between color and product

            //Many to many relationship between warranty and product

            modelBuilder.Entity<ProductWarranty>().HasKey(pw => new { pw.Product_Id, pw.Warranty_Id });

            modelBuilder.Entity<ProductWarranty>()
                .HasOne<Product>(pw => pw.Product)  
                .WithMany(p => p.ProductWarranties)
                .HasForeignKey(pw => pw.Product_Id);

            modelBuilder.Entity<ProductWarranty>()
                .HasOne<Warranty>(pw => pw.Warranty)
                .WithMany(w => w.ProductWarranties)
                .HasForeignKey(pw => pw.Warranty_Id);

            //Many to many relationship between warranty and product

            #region Category seeding...
            modelBuilder.Entity<Category>().HasData
            (
                new Category
                {
                    Id = new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"),
                    Name = "Smartphones and accessories",
                    Description = "Discover cutting-edge smartphones and accessories for seamless connectivity." +
                    " Elevate your mobile experience with the latest technology, from feature-packed smartphones to stylish" +
                    " and functional accessories that enhance usability and style.",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Category
                {
                    Id = new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"),
                    Name = "Smart gadgets",
                    Description = "Explore the future with smart gadgets. Experience seamless integration of technology into daily life with innovative devices," +
                    " from smart home solutions to wearables, enhancing convenience, connectivity, and efficiency.",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Category
                {
                    Id = new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"),
                    Name = "Notebooks, PCs, tablets",
                    Description = "Empower your digital journey with notebooks, PCs, and tablets. Find the perfect balance of performance and portability." +
                    " Choose from a diverse range of computing solutions tailored to your needs.",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Category
                {
                    Id = new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"),
                    Name = "Products for gamers",
                    Description = "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories," +
                    " and advanced gear designed to take your gaming to the next level.",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Category
                {
                    Id = new Guid("f6b3406c-6046-486f-8ba8-a896ac26fe90"),
                    Name = "Kitchen appliances",
                    Description = "Transform your kitchen with modern convenience. Explore a range of innovative kitchen appliances, from efficient cookware to time-saving gadgets," +
                    " enhancing your culinary experience with style and functionality.",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Category
                {
                    Id = new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"),
                    Name = "Home appliances",
                    Description = "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions," +
                    " making everyday tasks convenient and your living space more comfortable.",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Category
                {
                    Id = new Guid("d2bc155a-9de0-40ed-b3e7-1a4c0983c2e5"),
                    Name = "Beauty and health equipment",
                    Description = "Discover a world of well-being with beauty and health equipment. From advanced skincare devices to fitness technology," +
                    " elevate your self-care routine with innovative products designed to promote beauty and wellness.",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Category
                {
                    Id = new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"),
                    Name = "TV, audio and photo",
                    Description = "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound," +
                    " and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Category
                {
                    Id = new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"),
                    Name = "Hobby and entertainment",
                    Description = "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories," +
                    " and advanced gear designed to take your gaming to the next level.",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Category
                {
                    Id = new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"),
                    Name = "Construction supplies",
                    Description = "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound," +
                    " and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Category
                {
                    Id = new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"),
                    Name = "Automotive products",
                    Description = "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound," +
                    " and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Category
                {
                    Id = new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"),
                    Name = "House and garden",
                    Description = "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions," +
                    " making everyday tasks convenient and your living space more comfortable.",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                }
            );

            #endregion

            #region Subcategory seeding...
            modelBuilder.Entity<Subcategory>().HasData
            (
                new Subcategory
                {
                    Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    Name = "Smartphones",
                    Description = "Smartphones have become indispensable in our daily lives," +
                    " serving as multifunctional devices that go beyond mere communication.",
                    Current_Category_Id = new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("d7f7fc67-7e84-4b72-90eb-99ab9a1fe1a8"),
                    Name = "Headphones",
                    Description = "Dive into superior sound quality with our sleek and comfortable headphones." +
                    " Whether wireless or wired, enjoy immersive audio and noise cancellation," +
                    " making them an essential accessory for music lovers and gamers alike.",
                    Current_Category_Id = new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("23f8c33a-16fc-4eaa-9c3e-b97e130dce9d"),
                    Name = "Push-button phones",
                    Description = "Experience simplicity and reliability with our push-button phones." +
                    " Effortlessly dial numbers with user-friendly keypads, ensuring quick and convenient communication. " +
                    "These phones combine classic design with modern functionality, providing a straightforward and dependable means of staying connected in the digital age.",
                    Current_Category_Id = new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("c1a5eab4-fcb5-4a76-8447-cbe95f4a4cc4"),
                    Name = "Home and office phones",
                    Description = "Stay connected effortlessly with our range of home and office phones. Designed for convenience, these phones blend functionality with sleek aesthetics, " +
                    "offering reliable communication solutions. Whether you're organizing your home or optimizing your office, our phones provide crystal-clear audio and user-friendly features for seamless conversations.",
                    Current_Category_Id = new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"),
                    Name = "Phone accessories",
                    Description = "Elevate your mobile experience with our diverse range of phone accessories. From stylish cases that provide protection to chargers that keep you powered up, our collection enhances the functionality and style of your device." +
                    " Explore a variety of accessories, including screen protectors, stands, and innovative gadgets, ensuring your phone is both personalized and optimized for your lifestyle.",
                    Current_Category_Id = new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("e3e9a6a7-6f1c-43bb-b0ac-6f646fa307fd"),
                    Name = "Headphone accessories",
                    Description = "Enhance your audio experience with our range of headphone accessories. " +
                    "From comfortable ear cushions to tangle-free cables, our collection ensures optimal comfort and convenience. " +
                    "Explore accessories like stylish cases, adapters, and stands to complement your headphones," +
                    " allowing you to personalize and elevate your listening setup effortlessly.",
                    Current_Category_Id = new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("59053d5f-cd74-4e42-8e4a-42ebd80d1c1d"),
                    Name = "Tablets",
                    Description = "Explore the versatility of modern technology with our range of tablets. Sleek and portable, these devices offer a seamless blend of productivity and entertainment." +
                    " Whether you're browsing, working, or enjoying multimedia content, our tablets deliver stunning visuals and efficient performance. " +
                    "Stay connected on the go with these compact and feature-rich companions, redefining the way you experience digital mobility.",
                    Current_Category_Id = new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"),
                    Name = "Smart watches",
                    Description = "Embrace the future of wearable technology with our smartwatches. Seamlessly blending style and functionality, these devices go beyond traditional timekeeping." +
                    " Monitor your health, receive notifications, and stay connected with cutting-edge features. With sleek designs and intuitive interfaces, our smartwatches empower you to navigate your day effortlessly," +
                    " combining fashion and innovation on your wrist.",
                    Current_Category_Id = new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("07ff4b23-b509-41e2-b932-37eae200181c"),
                    Name = "Smart bracelets",
                    Description = "Elevate your fitness and style with our smart bracelets. These sleek, wearable devices seamlessly integrate technology into your lifestyle. Track your health and fitness metrics, receive notifications," +
                    " and stay connected on the go. Designed for comfort and performance, our smart bracelets are the perfect companions for those who prioritize both wellness and fashion in their daily lives.",
                    Current_Category_Id = new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("8d60aefa-e6cb-4b90-9e90-0de7d4d01a7b"),
                    Name = "Smart equipment",
                    Description = "Transform your surroundings with our collection of smart equipment. From intelligent home devices to cutting-edge gadgets, these products seamlessly integrate technology into your daily life. " +
                    "Enjoy enhanced efficiency, connectivity, and control as our smart equipment empowers you to create a modern and intelligent living or working space. Explore the future of convenience with our innovative selection.",
                    Current_Category_Id = new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("b0f7748c-02cf-46e3-9c82-412c284240d1"),
                    Name = "Headphones",
                    Description = "Dive into a world of immersive audio with our premium headphones. Offering crystal-clear sound, comfortable designs, and sleek aesthetics, our headphones elevate your listening experience. " +
                    "Whether you're a music enthusiast, gamer, or on-the-go professional, our range includes wireless and wired options, ensuring a perfect fit for every lifestyle. " +
                    "Experience the power of superior sound quality with our cutting-edge headphone collection.",
                    Current_Category_Id = new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("431bbfe3-7e5d-4d90-b590-e20fb631ac3d"),
                    Name = "Wristwatches",
                    Description = "Accessorize your style and stay punctual with our curated selection of wristwatches." +
                    " From classic elegance to modern innovation, our collection offers a timepiece for every occasion. " +
                    "Choose from a variety of designs, materials, and features, ensuring both functionality and fashion." +
                    " Embrace the art of timekeeping with our wristwatches, where precision meets personal expression.",
                    Current_Category_Id = new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"),
                    Name = "Transportation",
                    Description = "Embark on seamless journeys with our diverse transportation solutions." +
                    " From sleek electric cars to reliable bicycles and innovative scooters, our collection is designed for modern mobility." +
                    " Discover eco-friendly options and cutting-edge technologies that redefine how you move. Whether commuting or exploring," +
                    " our transportation offerings prioritize efficiency, sustainability, and a connected travel experience.",
                    Current_Category_Id = new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("aab6cbec-dc48-4d4f-a480-137c3e8605c9"),
                    Name = "Children's smart watches",
                    Description = "Empower your child with a blend of fun and safety using our children's smartwatches. " +
                    "These wearable gadgets offer a secure connection, allowing you to stay in touch while granting your child a sense of independence. " +
                    "Packed with features like GPS tracking, calling, and safety alerts, our smartwatches provide peace of mind for parents and an exciting, interactive experience for kids. " +
                    "Nurture their curiosity with technology that's both entertaining and secure.",
                    Current_Category_Id = new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"),
                    Name = "Laptops",
                    Description = "Unleash productivity and creativity with our diverse range of laptops. From sleek ultrabooks to powerful gaming machines, our collection caters to every need." +
                    " Experience cutting-edge technology, vibrant displays, and efficient performance in portable designs. Whether you're a professional on the go or a content creator pushing boundaries, " +
                    "our laptops offer a perfect blend of style, power, and versatility for the modern user.",
                    Current_Category_Id = new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("6f1d8a61-5b88-4e67-a11f-651b3d09a432"),
                    Name = "Computers",
                    Description = "Experience the power of innovation with our comprehensive range of computers. From sleek desktops to versatile all-in-ones, our collection caters to diverse needs. " +
                    "Explore high-performance PCs designed for gaming, creative endeavors, or professional tasks. Whether you seek cutting-edge technology, powerful processing, or seamless connectivity, " +
                    "our computers deliver a perfect balance of performance and reliability for the modern computing experience.",
                    Current_Category_Id = new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("2d61c82b-9ba7-4528-9e14-d8de745f32b3"),
                    Name = "Monitors",
                    Description = "Immerse yourself in vivid visuals and enhanced productivity with our selection of monitors. From sleek designs to high-resolution displays, our collection caters to diverse needs." +
                    " Whether you're a gamer, designer, or professional, our monitors offer crisp images, fast refresh rates, and ergonomic features for a seamless viewing experience. " +
                    "Elevate your workspace or gaming setup with technology that brings clarity and efficiency to your screen.",
                    Current_Category_Id = new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("e2f1a8b3-58e8-4962-a7b8-9e7c3ecb301c"),
                    Name = "Computer parts",
                    Description = "Build and upgrade with confidence using our comprehensive selection of computer parts. Explore a wide range of components, from powerful processors and graphics cards to reliable storage solutions and high-speed memory." +
                    " Whether you're customizing your gaming rig or enhancing your workstation, our collection ensures top-tier performance, compatibility, and reliability for all your computing needs.",
                    Current_Category_Id = new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("63ad6b9b-4b3a-4b1f-b823-276db0a0c28f"),
                    Name = "Network equipment",
                    Description = "Optimize connectivity and communication with our advanced network equipment." +
                    " From routers and switches to access points and modems, our collection is designed to enhance your network performance." +
                    " Enjoy seamless data transfer, secure connections, and reliable internet access for both home and business environments." +
                    " Explore cutting-edge technology that ensures a fast, stable, and secure network infrastructure tailored to your connectivity needs.",
                    Current_Category_Id = new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("1f9db05a-b5cc-4ea7-8e6d-93e12b5b8d5d"),
                    Name = "Tablets",
                    Description = "Discover the perfect blend of portability and performance with our versatile tablets. " +
                    "From sleek designs to vibrant displays, our collection offers a range of options to suit your digital lifestyle. " +
                    "Ideal for work, entertainment, or creativity on the go, our tablets feature powerful processors, stunning graphics, and intuitive interfaces. " +
                    "Stay connected and productive with these compact devices that redefine the way you experience digital mobility.",
                    Current_Category_Id = new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("a85e1a45-741c-47b7-8dfb-df7f5e87c76b"),
                    Name = "Computer accessories",
                    Description = "Elevate your computing experience with our extensive range of computer accessories. From ergonomic peripherals like keyboards and mice to essential adapters," +
                    " stylish laptop bags, and cutting-edge external drives – our collection enhances functionality and style. Explore accessories that complement your work or gaming setup," +
                    " providing convenience and efficiency in every click. Personalize your computing space with the latest and most innovative computer accessories.",
                    Current_Category_Id = new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("77d68ed5-b2cb-41a3-84f0-c6d0cbfb11a0"),
                    Name = "Video game equipment",
                    Description = "Dive into the world of gaming with our cutting-edge video game equipment. From high-performance gaming consoles and controllers to immersive virtual reality systems," +
                    " our collection caters to enthusiasts of all levels. Experience top-notch graphics, precision controls, and seamless gameplay with our advanced gaming gear. " +
                    "Whether you're a casual gamer or a competitive player, our equipment ensures an unparalleled and thrilling gaming experience.",
                    Current_Category_Id = new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("1eb107f7-8525-4ed0-af50-8e01f7731d0b"),
                    Name = "Peripheral equipment",
                    Description = "Enhance your computing setup with our diverse range of peripheral equipment. From ergonomic keyboards and precision mice to high-resolution monitors and versatile docking stations, our collection is designed to optimize your workflow." +
                    " Experience comfort, efficiency, and style with peripherals that complement your unique needs. Elevate your computing experience with the latest and most innovative peripheral equipment for both work and play.",
                    Current_Category_Id = new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("042a0d33-d091-4a01-b63c-e676d879d4c8"),
                    Name = "Drawing tablets",
                    Description = "Unleash your creativity with precision using our drawing tablets. Designed for digital artists and professionals, these tablets offer an immersive drawing experience with pressure-sensitive pens and responsive surfaces. " +
                    "Explore a range of sizes and features to suit your artistic needs, whether you're sketching, illustrating, or editing. Elevate your digital artistry with our advanced drawing tablets, combining technology and creativity seamlessly.",
                    Current_Category_Id = new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("7a28c90b-9a2e-4ab6-8255-7c7e6c653685"),
                    Name = "PlayStation",
                    Description = "Dive into a world of immersive gaming with the PlayStation console series. Whether you're a solo player or enjoy multiplayer experiences, PlayStation delivers cutting-edge technology, stunning graphics, and a vast library of games." +
                    " From the latest releases to beloved classics, the PlayStation ecosystem offers entertainment for every gaming enthusiast. Elevate your gaming experience with the iconic PlayStation console, where innovation meets unparalleled gameplay.",
                    Current_Category_Id = new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("17f2c0cc-38d3-452e-88ce-510090de2b92"),
                    Name = "Gaming smartphones",
                    Description = "Unleash the power of gaming on the go with our cutting-edge gaming smartphones. Engineered for high-performance gaming experiences, these devices combine top-tier processors, advanced cooling systems, and immersive displays. " +
                    "Enjoy seamless gameplay, stunning graphics, and responsive controls as you dive into your favorite mobile games. Elevate your gaming journey with our gaming smartphones, where technology meets the thrill of unparalleled mobile gaming.",
                    Current_Category_Id = new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("dbbba1f1-e5fc-4f0e-bc4d-263d2cfe9290"),
                    Name = "Gamepad for smartphone",
                    Description = "Enhance your mobile gaming experience with our gamepad for smartphones. Designed for comfort and precision, these controllers bring console-like gaming to your fingertips. With ergonomic designs and customizable buttons," +
                    " our gamepads offer seamless control for a wide range of games. Elevate your mobile gaming adventures and enjoy immersive gameplay with the convenience of our responsive and versatile gamepads.",
                    Current_Category_Id = new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("29c45e6f-6a5e-4c46-a5ec-71a7c6ee81f8"),
                    Name = "Gaming monitors",
                    Description = "Dive into the world of immersive gaming with our high-performance gaming monitors. Engineered for speed and precision, these monitors boast high refresh rates, low input lag, and vibrant displays." +
                    " Experience fluid graphics, sharp details, and responsive gameplay as you immerse yourself in your favorite titles. Whether you're a casual gamer or a competitive esports enthusiast," +
                    " our gaming monitors redefine visual excellence for an unparalleled gaming experience.",
                    Current_Category_Id = new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("17bbd60c-503a-46f4-9910-c44d2b7efba6"),
                    Name = "Game peripherals",
                    Description = "Elevate your gaming setup with our premium game peripherals. From responsive keyboards and precision mice to immersive headsets and customizable controllers, our collection is designed to enhance every aspect of your gaming experience." +
                    " Explore cutting-edge technology, ergonomic designs, and customizable features that cater to both casual and competitive gamers. Level up your gaming performance and immerse yourself in a world of unparalleled control and precision with our game peripherals.",
                    Current_Category_Id = new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("8725ff1b-d64d-4f14-b0c1-663c16fdd554"),
                    Name = "Computer parts",
                    Description = "Upgrade and optimize your computing experience with our comprehensive range of computer parts. Explore powerful processors, high-capacity storage solutions, cutting-edge graphics cards, and fast memory options. " +
                    "Whether you're building a custom PC, enhancing gaming performance, or improving productivity, our selection of computer parts ensures top-tier quality, compatibility, and reliability for your computing needs.",
                    Current_Category_Id = new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("a41241d1-45ac-4715-8e92-9cbf9f9b3ef7"),
                    Name = "Gaming monitors",
                    Description = "Dive into an immersive gaming experience with our high-performance gaming monitors. Designed for speed and precision, these monitors deliver high refresh rates, low input lag, and vibrant displays. " +
                    "Enjoy fluid graphics, sharp details, and responsive gameplay as you plunge into your favorite titles. Whether you're a casual gamer or an esports enthusiast, our gaming monitors redefine visual excellence, offering an unparalleled and responsive gaming environment.",
                    Current_Category_Id = new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("d0d7aa6e-bcb3-4c14-96f9-0a45e9149a67"),
                    Name = "Gaming notebooks",
                    Description = "Unleash gaming excellence on the go with our cutting-edge gaming notebooks. Engineered for portable power, these laptops feature high-performance processors, powerful graphics cards, and high-refresh-rate displays." +
                    " Immerse yourself in vivid graphics and responsive gameplay wherever you go." +
                    " Whether you're a casual gamer or a competitive enthusiast, our gaming notebooks provide a perfect blend of performance, portability, and style for an exceptional gaming experience on the move.",
                    Current_Category_Id = new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("d1bba8aa-b0d4-42a7-b08f-71b5e7757cb3"),
                    Name = "Xbox",
                    Description = "Dive into the gaming world with the Xbox console series. Designed for unparalleled entertainment, Xbox offers a vast library of games, stunning graphics, and immersive experiences. " +
                    "From the latest releases to classic favorites, the Xbox ecosystem caters to gamers of all tastes and preferences. Elevate your gaming journey with cutting-edge technology and a community that celebrates the love of gaming. " +
                    "Welcome to the next level of entertainment with Xbox.",
                    Current_Category_Id = new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("7f9e65a1-6c4c-4dbb-a3d1-9e1c2b5b35b0"),
                    Name = "Great kitchen appliances",
                    Description = "Transform your kitchen into a culinary haven with our collection of great kitchen appliances." +
                    " From high-performance blenders and versatile food processors to sleek coffee makers and efficient toasters, our appliances combine innovation and style." +
                    " Experience the joy of cooking and entertaining with reliable, easy-to-use appliances that enhance your culinary skills. " +
                    "Elevate your kitchen experience with our range of appliances designed to make every meal a delight.",
                    Current_Category_Id = new Guid("f6b3406c-6046-486f-8ba8-a896ac26fe90"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("e8a4d6b2-0b4f-4372-8292-665ae7d3f29e"),
                    Name = "Dishes",
                    Description = "Elevate your dining experience with our exquisite collection of dishes. " +
                    "From elegant dinnerware sets to versatile serving plates, our dishes combine style and functionality." +
                    " Explore a variety of designs, materials, and patterns to suit every occasion, from casual meals to formal gatherings." +
                    " Create a visually appealing table setting with our high-quality dishes that add a touch of sophistication to your dining space.",
                    Current_Category_Id = new Guid("f6b3406c-6046-486f-8ba8-a896ac26fe90"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("45c89a7f-fa4d-4c3d-9f21-827f11a9c834"),
                    Name = "Kitchen equipment for food preparation",
                    Description = "Optimize your food preparation process with our comprehensive collection of kitchen equipment." +
                    " From high-performance blenders and food processors to reliable mixers and efficient chopping tools, our range is designed to enhance your culinary experience." +
                    " Experience the joy of cooking with precision and ease using our innovative kitchen equipment." +
                    " Elevate your culinary skills and create delicious meals with the right tools for every step of the preparation journey.",
                    Current_Category_Id = new Guid("f6b3406c-6046-486f-8ba8-a896ac26fe90"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("2b3fde56-118a-4f41-8a93-6fd157f2c4b5"),
                    Name = "Installed kitchen appliances",
                    Description = "Upgrade your kitchen with our installed kitchen appliances, seamlessly blending form and function." +
                    " From sleek built-in ovens and stylish cooktops to integrated refrigerators and advanced dishwashers, our collection combines modern design with cutting-edge technology." +
                    " Experience the convenience of a well-equipped kitchen, where appliances are seamlessly integrated for a cohesive and efficient cooking space." +
                    " Elevate your culinary environment with our range of installed kitchen appliances.",
                    Current_Category_Id = new Guid("f6b3406c-6046-486f-8ba8-a896ac26fe90"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("c09b1a8d-6922-47d2-8b9c-845c4a3cf79c"),
                    Name = "Preparation of drink",
                    Description = "Craft the perfect beverage with our premium drink preparation essentials." +
                    " From state-of-the-art coffee makers and efficient tea infusers to innovative blenders for smoothies and cocktails, our collection ensures a delightful drink experience." +
                    " Elevate your moments with precision and style, whether brewing your favorite coffee blend or concocting refreshing beverages. " +
                    "Embrace the art of drink preparation with our high-quality tools designed to enhance every sip.",
                    Current_Category_Id = new Guid("f6b3406c-6046-486f-8ba8-a896ac26fe90"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("d0e3a99d-8d16-4a2a-81d6-5a9db9a40b28"),
                    Name = "Great appliances for the home",
                    Description = "Transform your home into a haven of convenience and efficiency with our collection of great home appliances." +
                    " From high-performance vacuum cleaners and energy-efficient washing machines to smart thermostats and innovative home security systems, our appliances enhance comfort and streamline daily tasks." +
                    " Experience the latest in technology and design, ensuring that each appliance not only serves a purpose but also elevates your home living experience." +
                    " Welcome to a smarter, more comfortable home with our range of great appliances.",
                    Current_Category_Id = new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("a1f5c6b3-509d-43a8-8d38-745e20d8f48b"),
                    Name = "Small appliances for the home",
                    Description = "Elevate your home living experience with our curated selection of small appliances." +
                    " From compact coffee makers and versatile food processors to space-saving irons and efficient hand blenders, our collection combines functionality and style." +
                    " Streamline daily tasks and add convenience to your routine with these thoughtfully designed appliances." +
                    " Discover the perfect blend of performance and aesthetics, enhancing both the functionality and charm of your living space.",
                    Current_Category_Id = new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("3c718a9b-8d43-4f45-8450-dce3627c3b04"),
                    Name = "Climate technology",
                    Description = "Create a comfortable and controlled environment with our advanced climate technology solutions." +
                    " From smart thermostats and energy-efficient air purifiers to innovative heating and cooling systems, our collection is designed to enhance your indoor comfort." +
                    " Experience the latest in climate control technology, optimizing energy efficiency and providing personalized settings for your home or office." +
                    " Elevate your living and working spaces with our cutting-edge climate technology for a healthier, more comfortable environment.",
                    Current_Category_Id = new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("6e8a719f-1c35-49a3-9209-6a9f132d2f0f"),
                    Name = "Climate accessories",
                    Description = "Enhance your control over the indoor environment with our range of climate accessories." +
                    " From smart thermostats and air purifiers to efficient humidifiers and space heaters, our collection complements your climate control system." +
                    " Create a personalized and comfortable atmosphere in every room with accessories designed for efficiency and convenience." +
                    " Elevate your indoor experience with our climate accessories, ensuring a tailored and enjoyable environment throughout the seasons.",
                    Current_Category_Id = new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("f2c4d60a-8e3a-4aa6-b8c6-754497a65a5b"),
                    Name = "Household products",
                    Description = "Discover a world of convenience and efficiency with our diverse range of household products." +
                    " From cleaning essentials like vacuum cleaners and mops to organization solutions like storage containers and shelving units, our collection is designed to streamline your daily tasks." +
                    " Experience the perfect blend of functionality and style as our household products enhance the comfort and aesthetics of your living space." +
                    " Elevate your home living with our thoughtfully curated selection of essential household items.",
                    Current_Category_Id = new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("9d7f5e6a-20e3-4a57-b529-6d6f104e86c9"),
                    Name = "Accessories for home appliances",
                    Description = "Optimize the functionality and style of your home appliances with our range of accessories." +
                    " From specialized attachments for kitchen appliances to add-ons for cleaning and maintenance tools, our collection is designed to enhance the performance and versatility of your household equipment." +
                    " Explore thoughtful additions that cater to every need, ensuring a seamless and efficient experience with your appliances. Elevate the utility of your home appliances with our curated selection of accessories.",
                    Current_Category_Id = new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("8b9c3aef-6154-4c9d-ae56-7a3df134f71b"),
                    Name = "Hairstyle",
                    Description = "Transform your look with our diverse collection of hairstyling tools and products." +
                    " From high-quality hairdryers and professional-grade straighteners to a variety of styling brushes and hair care products, our range caters to all your hairstyling needs." +
                    " Whether you're aiming for sleek and straight, bouncy curls, or a trendy updo, our hairstyling tools and products offer versatility and creativity." +
                    " Elevate your personal style and express yourself with the latest in hairstyling innovation.",
                    Current_Category_Id = new Guid("d2bc155a-9de0-40ed-b3e7-1a4c0983c2e5"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("1f6e8d24-8653-4270-8e3d-6cfe922a4b8a"),
                    Name = "Shaving and haircut",
                    Description = "Craft your signature look with our comprehensive selection of shaving and haircut essentials." +
                    " From precision trimmers and electric razors to grooming kits and high-quality shaving creams, our collection offers everything you need for a polished appearance." +
                    " Enjoy a personalized grooming experience with tools designed for precision, comfort, and style. " +
                    "Elevate your self-care routine and achieve a well-groomed look effortlessly with our curated shaving and haircut essentials.",
                    Current_Category_Id = new Guid("d2bc155a-9de0-40ed-b3e7-1a4c0983c2e5"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("47bd8a53-93c2-4bc7-b77b-9c6d8e9352c6"),
                    Name = "Health",
                    Description = "Prioritize your well-being with our comprehensive range of health products." +
                    " From fitness trackers and home workout equipment to nutritional supplements and personal care items, our collection is designed to support a healthy and active lifestyle." +
                    " Explore innovative solutions that cater to physical and mental well-being, ensuring you have the tools to prioritize health in your daily routine." +
                    " Elevate your journey to a healthier you with our thoughtfully curated health products.",
                    Current_Category_Id = new Guid("d2bc155a-9de0-40ed-b3e7-1a4c0983c2e5"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("f6c2d95e-4d7d-41f2-aa1a-23a40dd8b4b9"),
                    Name = "Health",
                    Description = "Prioritize your well-being with our comprehensive range of health products." +
                    " From fitness trackers and home workout equipment to nutritional supplements and personal care items, our collection is designed to support a healthy and active lifestyle." +
                    " Explore innovative solutions that cater to physical and mental well-being, ensuring you have the tools to prioritize health in your daily routine." +
                    " Elevate your journey to a healthier you with our thoughtfully curated health products.",
                    Current_Category_Id = new Guid("d2bc155a-9de0-40ed-b3e7-1a4c0983c2e5"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("afe0d8b2-4f44-4821-a6b9-5e1e77d892db"),
                    Name = "TV brands",
                    Description = "",
                    Current_Category_Id = new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("94bd67a9-3c6a-4d1f-b2b2-0f8915ac5c2a"),
                    Name = "On TV technology",
                    Description = "",
                    Current_Category_Id = new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("3a6b95f8-eda4-45b8-9dd1-1aa64e2eeb8c"),
                    Name = "TV accessories",
                    Description = "Enhance your television experience with our range of TV accessories." +
                    " From versatile wall mounts and sleek soundbars to advanced remote controls and immersive lighting solutions," +
                    " our collection is designed to complement and elevate your viewing setup." +
                    " Explore accessories that add convenience, style, and enhanced functionality to your entertainment space." +
                    " Transform your TV into a complete multimedia experience with our thoughtfully curated selection of TV accessories.",
                    Current_Category_Id = new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("d1e39c7c-5d2d-42f1-982d-cf6b3f46b9a1"),
                    Name = "TV stands",
                    Description = "Elevate your viewing experience with our stylish and functional TV stands." +
                    " From modern designs with sleek finishes to versatile options with ample storage, our collection caters to various tastes and needs." +
                    " Discover sturdy stands that complement your home decor while providing a stable platform for your television. " +
                    "Whether you prefer a minimalist look or need extra storage for entertainment essentials, our TV stands combine form and function to enhance your living space.",
                    Current_Category_Id = new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("7f6a8e21-8fe1-4f0f-93b9-af14ab0f86c1"),
                    Name = "Lenses, flashes, accessories",
                    Description = "Capture the perfect shot with our range of photography essentials." +
                    " From high-quality lenses and powerful flashes to versatile camera accessories, our collection caters to photographers of all levels." +
                    " Explore equipment that enhances creativity, ensures precision, and adds versatility to your photography gear." +
                    " Elevate your photographic skills with our carefully curated selection of lenses, flashes, and accessories designed to bring out the best in every shot.",
                    Current_Category_Id = new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("b8c2a1d4-6d8c-42e4-98fe-8c31a26a6a2c"),
                    Name = "TV diagonally",
                    Description = "",
                    Current_Category_Id = new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("4c9b5a81-7f8c-4ee0-8ba2-ead63a7dc6f3"),
                    Name = "TV in HD format",
                    Description = "",
                    Current_Category_Id = new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("9e4b6a3d-5e32-4ea7-bff4-34bc47eeef71"),
                    Name = "Camera and cameras",
                    Description = "Unleash your creativity with our comprehensive range of cameras and photography equipment." +
                    " From powerful DSLRs and compact mirrorless cameras to versatile action cameras and high-quality lenses, our collection caters to photographers of all levels." +
                    " Discover cutting-edge technology and innovative features that capture every moment in stunning detail. " +
                    "Elevate your photography experience with our curated selection of cameras and accessories, designed to meet the diverse needs of enthusiasts and professionals alike.",
                    Current_Category_Id = new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("7dfe9a0c-2457-4db2-9c59-0f3705dbde44"),
                    Name = "Audio equipment",
                    Description = "Immerse yourself in superior sound quality with our diverse range of audio equipment." +
                    " From high-fidelity speakers and headphones to powerful amplifiers and versatile audio accessories, our collection caters to audiophiles and music enthusiasts." +
                    " Explore cutting-edge technology that delivers crisp and immersive audio experiences." +
                    " Elevate your sound journey with our thoughtfully curated selection of audio equipment designed to enhance every note, beat, and melody in your favorite music.",
                    Current_Category_Id = new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("2a5c3d18-7a9e-4df0-9321-6d5a8a9b5d89"),
                    Name = "Video games",
                    Description = "Dive into the exciting world of video games with our extensive collection." +
                    " From immersive story-driven adventures to heart-pounding action and multiplayer experiences, our selection caters to gamers of all preferences." +
                    " Explore the latest releases and classic favorites across various genres, ensuring there's something for every gaming enthusiast." +
                    " Elevate your gaming experience with our diverse range of video games, where entertainment and excitement come together for unforgettable virtual adventures.",
                    Current_Category_Id = new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("1d6e8b7f-94c0-4838-9e6e-ec91f0f8f57b"),
                    Name = "PlayStation",
                    Description = "Dive into unparalleled gaming experiences with the PlayStation console series." +
                    " From stunning graphics to a vast library of games, the PlayStation ecosystem offers entertainment for every gaming enthusiast." +
                    " Explore the latest releases, engage in multiplayer adventures, and enjoy a platform that continues to redefine interactive entertainment." +
                    " Elevate your gaming journey with cutting-edge technology and an immersive gaming community. Welcome to the world of PlayStation, where innovation meets unparalleled gameplay.",
                    Current_Category_Id = new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("6d8b2a4e-1c3d-4e46-88c7-9f5ea13c1f8d"),
                    Name = "Nintendo",
                    Description = "Embark on whimsical adventures and classic gaming fun with Nintendo." +
                    " From iconic franchises like Mario and Zelda to innovative gaming consoles like the Nintendo Switch, our collection offers a diverse range of games and experiences." +
                    " Explore family-friendly titles, engaging multiplayer options, and the charm of Nintendo's unique gaming world." +
                    " Elevate your gaming with the creativity, nostalgia, and timeless joy that Nintendo brings to players of all ages.",
                    Current_Category_Id = new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("8f5c3a1d-62b9-4b82-9d8f-ace75eab8e7b"),
                    Name = "Sports products",
                    Description = "Maximize your performance and embrace an active lifestyle with our range of sports products." +
                    " From high-quality athletic wear and supportive footwear to cutting-edge equipment for various sports, our collection caters to enthusiasts of all levels." +
                    " Explore gear that prioritizes comfort, durability, and performance, ensuring you have the right tools for your fitness journey." +
                    " Elevate your sports experience with our carefully curated selection of products designed to inspire and support your active endeavors.",
                    Current_Category_Id = new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("b8a3d6c9-7fe0-4fbb-9b48-f4c11c0d48a7"),
                    Name = "Studio accessories",
                    Description = "Optimize your creative space with our curated selection of studio accessories." +
                    " From adjustable lighting and ergonomic furniture to cable management solutions and versatile storage options, our collection is designed to enhance functionality and aesthetics in your studio." +
                    " Explore accessories that cater to the specific needs of photographers, artists, musicians, and content creators." +
                    " Elevate your studio environment with thoughtfully chosen accessories that bring efficiency and style to your creative workspace.",
                    Current_Category_Id = new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("5a4f8ec3-291e-4e65-9db3-fb4e5c9d8a1d"),
                    Name = "Transportation",
                    Description = "Explore seamless mobility with our diverse range of transportation solutions." +
                    " From eco-friendly electric vehicles and efficient bicycles to innovative scooters and smart city commuting solutions, our collection is designed to redefine the way you move." +
                    " Discover cutting-edge technology that prioritizes sustainability, efficiency, and connectivity, ensuring your journeys are both enjoyable and eco-conscious." +
                    " Elevate your transportation experience with our thoughtfully curated selection of products that cater to modern mobility needs.",
                    Current_Category_Id = new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("8a9d6f1c-5b0e-487e-9c7f-2e01a963e6b7"),
                    Name = "Musical instruments",
                    Description = "Unleash your musical passion with our extensive collection of musical instruments." +
                    " From classic guitars and versatile keyboards to powerful drums and wind instruments, our range caters to musicians of all levels and genres." +
                    " Explore high-quality craftsmanship, innovative designs, and a variety of accessories that enhance your playing experience." +
                    " Elevate your musical journey with our carefully curated selection of instruments, ensuring you have the tools to express yourself and create beautiful melodies.",
                    Current_Category_Id = new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("5c0a8f1d-4d7e-4950-abe6-3e8d6f9b2c8a"),
                    Name = "Power tools for construction",
                    Description = "Empower your construction projects with our robust selection of power tools." +
                    " From high-performance drills and saws to versatile sanders and powerful impact wrenches, our collection is designed to meet the demands of construction professionals." +
                    " Explore reliable brands, innovative features, and durable construction that ensure precision and efficiency on the job." +
                    " Elevate your construction capabilities with our carefully curated range of power tools, delivering the strength and precision needed to tackle any project.",
                    Current_Category_Id = new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("1a3f6c8e-cd94-4ac8-84b9-02c3f9d8e0b6"),
                    Name = "Hand tools for construction",
                    Description = "Equip yourself with the right tools for the job with our comprehensive selection of hand tools for construction." +
                    " From sturdy hammers and versatile screwdrivers to precise levels and durable tape measures, our collection is designed to meet the needs of builders and craftsmen." +
                    " Explore ergonomic designs, reliable materials, and innovative features that enhance precision and efficiency on the construction site." +
                    " Elevate your craftsmanship with our thoughtfully curated range of hand tools, ensuring you have the essential instruments for successful construction projects.",
                    Current_Category_Id = new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("9e7a2c3b-0b15-4f33-ba7d-8cf9e4a1b5a8"),
                    Name = "Measuring and marking tools for construction",
                    Description = "Ensure accuracy and precision in your construction projects with our specialized measuring and marking tools." +
                    " From durable tape measures and laser levels to precise marking tools, our collection is designed to meet the exacting standards of construction professionals." +
                    " Explore ergonomic designs and advanced features that enhance efficiency and accuracy on the job." +
                    " Elevate your construction capabilities with our carefully curated range of measuring and marking tools, providing the precision needed for successful and precise construction projects.",
                    Current_Category_Id = new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("7b4c1e8d-36a2-42b1-af95-98d36aefb37d"),
                    Name = "Construction clothing and accessories",
                    Description = "Gear up for construction success with our range of durable and functional construction clothing and accessories." +
                    " From rugged work boots and protective eyewear to high-visibility vests and weather-resistant jackets, our collection prioritizes safety and comfort on the construction site." +
                    " Explore durable fabrics, innovative designs, and essential accessories that enhance your workwear experience." +
                    " Elevate your construction gear with our carefully curated selection, ensuring you're equipped for the demands of the job while staying safe and comfortable.",
                    Current_Category_Id = new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("4c2f7b9d-b8a3-4f5c-8369-9e0d4f1e7c2d"),
                    Name = "Equipment",
                    Description = "Power your construction projects with our extensive range of construction equipment." +
                    " From heavy machinery like excavators and bulldozers to versatile tools like concrete mixers and jackhammers, our collection caters to the diverse needs of construction professionals." +
                    " Explore reliable brands, innovative features, and durable construction that ensures efficiency and productivity on the job site." +
                    " Elevate your construction capabilities with our carefully curated range of equipment, delivering the strength and versatility needed to tackle any project.",
                    Current_Category_Id = new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("1a9d6e8f-cd3b-4f80-8c65-3a0e5d8f6b1a"),
                    Name = "Construction consumables",
                    Description = "Ensure a seamless construction process with our wide range of construction consumables." +
                    " From high-quality adhesives and sealants to essential safety gear and durable work gloves, our collection caters to the diverse needs of construction professionals." +
                    " Explore reliable brands, innovative solutions, and materials that prioritize safety and efficiency on the job site." +
                    " Elevate your construction capabilities with our carefully curated range of consumables, providing the essential tools and supplies for successful and secure construction projects.",
                    Current_Category_Id = new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("5e8c4f2d-7a19-4d5e-a18b-9c32f6d8c5b7"),
                    Name = "Plumbing",
                    Description = "Efficient plumbing solutions for every project." +
                    " Explore our range of high-quality plumbing products, from durable pipes and fittings to reliable fixtures and innovative accessories." +
                    " Whether you're working on residential installations or commercial projects, our collection is designed to meet the diverse needs of plumbers and contractors." +
                    " Elevate your plumbing projects with our carefully curated selection, ensuring precision, durability, and efficiency in every installation and repair.",
                    Current_Category_Id = new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("2c6e7f8d-af34-48bd-b2a1-c5c8d39a6e4f"),
                    Name = "Discs and wheels",
                    Description = "Optimize your cutting and grinding tasks with our selection of high-quality discs and wheels." +
                    " From abrasive grinding wheels to precision cutting discs, our collection caters to various applications and materials." +
                    " Explore durable designs, reliable materials, and innovative features that ensure efficiency and precision in your projects." +
                    " Elevate your work with our carefully curated range of discs and wheels, providing the essential tools for metalworking, construction, and other applications.",
                    Current_Category_Id = new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("d9c6e8f5-742e-4d8f-a7e6-13d6c9b2a1d5"),
                    Name = "Oils and liquids",
                    Description = "Explore our range of high-quality oils and liquids designed to enhance performance and lubrication across various applications." +
                    " From specialized lubricants for machinery to essential oils for automotive maintenance, our collection prioritizes reliability and efficiency." +
                    " Discover carefully curated products with innovative formulations, ensuring optimal performance and longevity for your equipment." +
                    " Elevate your operations with our selection of oils and liquids, providing the essential fluids for smooth-running machinery and vehicles.",
                    Current_Category_Id = new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("8d2a5c6f-4e0b-495f-96b8-fd37a1c9e8d6"),
                    Name = "Automotive electronics",
                    Description = "Upgrade your vehicle's technology with our cutting-edge automotive electronics." +
                    " From advanced infotainment systems and GPS navigation to state-of-the-art car audio and safety electronics, our collection is designed to enhance your driving experience." +
                    " Explore innovative features, connectivity options, and safety solutions that bring modern technology to your vehicle." +
                    " Elevate your driving journey with our carefully curated range of automotive electronics, ensuring a seamless blend of entertainment, connectivity, and safety on the road.",
                    Current_Category_Id = new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("4e9b8c5a-d0e2-4af6-b6cf-d91c2f8e5b7a"),
                    Name = "Spare parts for cars",
                    Description = "Keep your vehicle running smoothly with our comprehensive selection of spare parts for cars." +
                    " From essential components like brake pads and filters to critical engine parts and electrical components, our collection caters to various makes and models." +
                    " Explore reliable brands, quality materials, and a diverse range of automotive spare parts that ensure durability and performance." +
                    " Elevate your vehicle maintenance with our carefully curated selection, providing the essential components for optimal functionality and longevity.",
                    Current_Category_Id = new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("a8b7c3d6-5e29-4d18-9c7a-e6f85d1c2b4c"),
                    Name = "Car accessories",
                    Description = "Enhance your driving experience with our curated selection of car accessories." +
                    " From versatile phone mounts and stylish seat covers to high-tech dash cams and convenient organizers, our collection caters to both functionality and style." +
                    " Explore accessories that elevate comfort, convenience, and aesthetics in your vehicle." +
                    " Whether you're looking for practical additions or personalized touches, our range of car accessories ensures you can tailor your driving space to suit your preferences." +
                    " Elevate your journey with thoughtfully chosen automotive enhancements.",
                    Current_Category_Id = new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("9a1d8e5b-8c0f-4e2a-af0d-7d5f3e6c4b0a"),
                    Name = "Car care tools",
                    Description = "Preserve the beauty of your vehicle with our selection of high-quality car care tools." +
                    " From durable microfiber cloths and soft-bristle brushes to precision applicators and efficient cleaning solutions, our collection is designed to keep your car looking its best." +
                    " Explore tools that cater to every aspect of car care, ensuring a thorough and effective cleaning and detailing process." +
                    " Elevate your car care routine with our carefully curated range of tools, providing the essential instruments for maintaining the pristine condition of your vehicle.",
                    Current_Category_Id = new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("c517b2c7-b756-49a6-9e5f-3b5414a0ee04"),
                    Name = "Smart home",
                    Description = "Transform your living space into an intelligent and efficient hub with our range of smart home solutions." +
                    " From smart thermostats and lighting systems to security cameras and voice-activated assistants, our collection integrates cutting-edge technology to enhance comfort, convenience, and security in your home." +
                    " Explore innovative devices that allow you to control and automate various aspects of your living space." +
                    " Elevate your lifestyle with our carefully curated selection of smart home products, bringing connectivity and intelligence to every corner of your home.",
                    Current_Category_Id = new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("b6e5f66a-db43-4003-a38e-43ce1fbd085f"),
                    Name = "New Year products",
                    Description = "Celebrate the New Year in style with our festive collection of products." +
                    " From sparkling decorations and elegant party supplies to thoughtful gifts and accessories, our range is designed to add joy and flair to your New Year's festivities." +
                    " Explore carefully curated items that bring a touch of celebration to your home and gatherings." +
                    " Elevate your New Year's experience with our selection of products that make ringing in the new chapter both memorable and enjoyable.",
                    Current_Category_Id = new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("11b9a66a-7c72-45e8-a235-5472d0081112"),
                    Name = "Batteries",
                    Description = "Power up your devices with our reliable range of batteries." +
                    " From everyday essentials like AA and AAA batteries to specialty sizes for cameras and watches, our collection ensures a dependable energy source for various electronics." +
                    " Explore long-lasting options from trusted brands, designed to meet the diverse needs of your devices." +
                    " Elevate your battery experience with our carefully curated selection, providing the essential power you need for a wide range of applications.",
                    Current_Category_Id = new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("528871d0-4cf0-4299-a359-84402b024ef6"),
                    Name = "Pool and equipment",
                    Description = "Dive into relaxation with our selection of pool and equipment essentials." +
                    " From durable pool accessories and comfortable loungers to efficient cleaning equipment and safety gear, our collection is designed to enhance your pool experience." +
                    " Explore carefully curated items that prioritize both fun and functionality." +
                    " Elevate your poolside oasis with our range of products, ensuring a refreshing and enjoyable environment for relaxation, entertainment, and aquatic activities.",
                    Current_Category_Id = new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("330a3663-3ed2-45ed-a1b4-8108d27c2a1a"),
                    Name = "Garden equipment",
                    Description = "Nurture your outdoor haven with our range of reliable garden equipment." +
                    " From robust lawnmowers and versatile trimmers to ergonomic hand tools and efficient watering systems, our collection is designed to enhance your gardening experience." +
                    " Explore carefully curated items that cater to both novice and experienced gardeners, ensuring a well-maintained and thriving garden." +
                    " Elevate your outdoor space with our selection of garden equipment, providing the essential tools for cultivating a beautiful and flourishing garden.",
                    Current_Category_Id = new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("dd5be212-cda5-44d3-abbc-7782ff8ed14d"),
                    Name = "Home decors",
                    Description = "Elevate your living spaces with our curated collection of home decors." +
                    " From stylish wall art and elegant vases to cozy throw pillows and modern lighting fixtures, our range is designed to add personality and charm to your home." +
                    " Explore carefully selected items that cater to various tastes and interior styles, ensuring you find the perfect accents to complement your decor." +
                    " Transform your living spaces and express your unique style with our thoughtfully curated selection of home decor items.",
                    Current_Category_Id = new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("026d0440-e16e-406f-a211-cb3c574cc6db"),
                    Name = "Drip systems",
                    Description = "Efficiently water your garden or landscape with our range of drip systems." +
                    " From drip irrigation kits to individual components like tubing, emitters, and filters, our collection is designed to provide a precise and water-efficient solution for plant hydration." +
                    " Explore carefully curated items that cater to various garden sizes and layouts, ensuring you have the right components for an effective drip irrigation system." +
                    " Elevate your gardening experience with our selection of drip systems, promoting water conservation and healthy plant growth.",
                    Current_Category_Id = new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("734b7def-3aa0-4081-96aa-227aaefd10ba"),
                    Name = "Garden supplies",
                    Description = "Nurture your garden with our comprehensive range of garden supplies." +
                    " From premium soil and fertilizers to durable gardening tools and stylish planters, our collection is designed to cater to the diverse needs of garden enthusiasts." +
                    " Explore carefully curated items that prioritize both functionality and aesthetics, ensuring you have the essentials for successful gardening." +
                    " Elevate your outdoor space with our selection of garden supplies, providing the tools and materials needed for a thriving and beautiful garden.",
                    Current_Category_Id = new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("cf5446f0-7c6b-44fc-8505-a7497ec84e18"),
                    Name = "Suitcases",
                    Description = "Travel in style with our curated collection of suitcases." +
                    " From durable hard-shell luggage to versatile soft-sided options, our range caters to various travel needs and preferences." +
                    " Explore carefully selected suitcases that prioritize both functionality and aesthetics, ensuring you have the right travel companion for your journey." +
                    " Elevate your travel experience with our thoughtfully curated selection of suitcases, providing durability, convenience, and style for your adventures near and far.",
                    Current_Category_Id = new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("c17aef02-ad65-4b0c-9a67-95ff2351ca3d"),
                    Name = "Lighting",
                    Description = "Illuminate your space with our diverse collection of lighting solutions." +
                    " From stylish pendant lights and modern floor lamps to versatile LED strips and innovative smart lighting, our range caters to various design preferences and functional needs." +
                    " Explore carefully curated lighting options that add ambiance and functionality to every room." +
                    " Elevate your living spaces with our thoughtfully selected collection, ensuring you find the perfect lighting solutions to create the desired atmosphere in your home.",
                    Current_Category_Id = new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Subcategory
                {
                    Id = new Guid("e4bc6462-c946-4903-87ab-861656ebc56a"),
                    Name = "Safes",
                    Description = "Secure your valuables with our range of safes designed for both home and office use." +
                    " From compact personal safes to larger fire-resistant options, our collection prioritizes reliable security for your important documents, jewelry, and belongings." +
                    " Explore carefully curated safes that feature advanced locking mechanisms, durable construction, and various size options." +
                    " Elevate your peace of mind with our thoughtfully selected safes, providing a secure and organized storage solution for your most valuable possessions.",
                    Current_Category_Id = new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                }
            );
            #endregion

            #region Deepcategory seeding...
            modelBuilder.Entity<Deepcategory>().HasData
            (
                new Deepcategory
                {
                    Id = new Guid("ff7f0ed7-33f4-4067-8278-d291bc6cab0b"),
                    Name = "Apple",
                    Description = "Explore the world of innovation with Apple's cutting-edge products." +
                    " From the iconic iPhone series to sleek MacBook laptops and powerful iPads, Apple offers a seamless ecosystem of devices." +
                    " Discover high-quality craftsmanship, stunning displays, and user-friendly interfaces that redefine technology." +
                    " Elevate your digital experience with Apple's thoughtfully designed products, ensuring a blend of style, performance, and innovation in every device.",
                    Current_Subcategory_Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("fd235119-1ca2-40f2-956e-17b040dd0d3a"),
                    Name = "OPPO",
                    Description = "Dive into the realm of innovation with OPPO's exceptional lineup of smartphones." +
                    " From sleek designs to cutting-edge camera technology, OPPO offers a range of devices that prioritize style and functionality." +
                    " Explore the latest in mobile innovation with OPPO's commitment to delivering impressive features and powerful performance." +
                    " Elevate your mobile experience with OPPO's thoughtfully crafted smartphones, blending style, innovation, and user-friendly design.",
                    Current_Subcategory_Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("f54296e5-2946-4e90-bc3c-0de027289e8d"),
                    Name = "Samsung",
                    Description = "Experience the epitome of technology and innovation with Samsung's diverse product range." +
                    " From flagship smartphones like the Galaxy series to smart TVs, home appliances, and cutting-edge wearables, Samsung offers a comprehensive ecosystem." +
                    " Discover stunning displays, powerful performance, and advanced features that redefine the way we live and connect." +
                    " Elevate your digital lifestyle with Samsung's thoughtfully designed products, bringing together quality, innovation, and versatility in every device.",
                    Current_Subcategory_Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("f5142e73-d14d-421e-8cac-3d5c9e3fdd42"),
                    Name = "Xiaomi",
                    Description = "Explore the world of innovation with Xiaomi's diverse range of technology products." +
                    " From feature-packed smartphones and smart home devices to fitness wearables and more, Xiaomi offers a wide array of products that combine quality with affordability." +
                    " Discover cutting-edge technology, sleek designs, and user-friendly interfaces that cater to various aspects of modern living." +
                    " Elevate your tech experience with Xiaomi's thoughtfully crafted products, where innovation meets accessibility.",
                    Current_Subcategory_Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("c0e1f0e5-cc6c-4bdf-b23e-840441c9fde2"),
                    Name = "TCL",
                    Description = "Dive into the world of technology with TCL smartphones, where innovation meets style." +
                    " Explore a range of feature-packed devices that offer stunning displays, powerful cameras, and sleek designs." +
                    " TCL smartphones deliver a seamless and immersive user experience, combining cutting-edge technology with affordability." +
                    " Elevate your mobile journey with TCL's thoughtfully crafted smartphones, redefining the way you capture, connect, and communicate.",
                    Current_Subcategory_Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("ac1807be-c7b3-483a-8a29-48da827ecd1f"),
                    Name = "HUAWEI",
                    Description = "Immerse yourself in innovation with Huawei's diverse range of technology products." +
                    " From flagship smartphones like the P and Mate series to cutting-edge wearables, laptops, and networking solutions, Huawei offers a comprehensive ecosystem." +
                    " Discover advanced camera technology, powerful performance, and sleek designs that redefine the possibilities of connected living." +
                    " Elevate your digital experience with Huawei's thoughtfully designed products, where innovation, craftsmanship, and efficiency converge.",
                    Current_Subcategory_Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("a98d197d-5d1b-46d7-8190-90cea77a73ff"),
                    Name = "Motorola",
                    Description = "Discover the legacy of innovation with Motorola's lineup of smartphones." +
                    " From iconic designs like the Moto G series to the sleek and powerful Moto Edge devices, Motorola offers a range of smartphones that combine style with functionality." +
                    " Explore advanced camera systems, long-lasting batteries, and near-stock Android experiences." +
                    " Elevate your mobile journey with Motorola's thoughtfully crafted smartphones, providing reliable performance and a user-friendly interface for everyday use.",
                    Current_Subcategory_Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("8c7b2f7f-6122-4770-ba40-23a0c034bcdf"),
                    Name = "Infinix",
                    Description = "Experience affordability and innovation with Infinix smartphones." +
                    " From sleek designs to feature-packed devices, Infinix offers a range of smartphones that prioritize both style and functionality." +
                    " Explore cutting-edge technology, impressive camera capabilities, and long-lasting batteries that cater to the diverse needs of users." +
                    " Elevate your mobile experience with Infinix's thoughtfully crafted smartphones, where performance meets affordability in a sleek package.",
                    Current_Subcategory_Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("686bdcfd-4a8c-4a46-8f2f-5c0221e26d95"),
                    Name = "Google",
                    Description = "Immerse yourself in the pure Android experience with Google's smartphones." +
                    " From the Pixel series, Google delivers devices known for their exceptional camera capabilities, seamless integration with Google services, and regular software updates." +
                    " Explore cutting-edge technology, clean design, and the convenience of Google Assistant." +
                    " Elevate your mobile journey with Google's thoughtfully crafted smartphones, where simplicity meets innovation for a pure Android experience.",
                    Current_Subcategory_Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("4848fc7f-44a6-497a-907c-ae9acb6e88ed"),
                    Name = "Tecno",
                    Description = "Discover the latest in mobile technology with Tecno smartphones." +
                    " From stylish designs to innovative features, Tecno offers a diverse range of smartphones that cater to different user needs." +
                    " Explore advanced camera systems, long-lasting batteries, and user-friendly interfaces." +
                    " Elevate your mobile experience with Tecno's thoughtfully crafted smartphones, combining style with functionality.",
                    Current_Subcategory_Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("462f1143-3776-42a1-9e70-7adc31fdff93"),
                    Name = "ASUS",
                    Description = "Explore cutting-edge technology and performance with ASUS smartphones." +
                    " From gaming-focused devices to flagship models, ASUS offers a range of smartphones that deliver powerful features and innovative designs." +
                    " Experience high-quality displays, impressive camera capabilities, and a seamless user interface." +
                    " Elevate your mobile gaming and entertainment with ASUS's thoughtfully crafted smartphones.",
                    Current_Subcategory_Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("40c96dfe-6df4-420b-9fb2-807cd31535bb"),
                    Name = "Vivo",
                    Description = "Immerse yourself in innovation and creativity with Vivo smartphones." +
                    " From sleek designs to advanced camera technology, Vivo offers a diverse range of smartphones that capture the essence of modern living." +
                    " Discover features like high-quality audio, vibrant displays, and powerful performance." +
                    " Elevate your mobile lifestyle with Vivo's thoughtfully crafted smartphones.",
                    Current_Subcategory_Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("332253aa-aa2f-4c83-b69b-2ef5afd1395a"),
                    Name = "Itel",
                    Description = "Experience affordability without compromising on performance with Itel smartphones." +
                    " From budget-friendly models to feature-packed devices, Itel offers a range of smartphones that cater to diverse user needs." +
                    " Explore reliable performance, long-lasting batteries, and user-friendly interfaces." +
                    " Elevate your mobile experience with Itel's thoughtfully crafted smartphones, delivering value and functionality.",
                    Current_Subcategory_Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("087d5394-9fb8-46f0-beba-a6c8df2c0114"),
                    Name = "Honor",
                    Description = "Explore the perfect blend of style and innovation with Honor smartphones." +
                    " From sleek designs to powerful features, Honor offers a range of smartphones that cater to the tech-savvy and fashion-conscious users." +
                    " Discover advanced camera systems, high-performance processors, and stunning displays." +
                    " Elevate your mobile lifestyle with Honor's thoughtfully crafted smartphones.",
                    Current_Subcategory_Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("011cd970-d173-45aa-95ba-242b3442809e"),
                    Name = "Blackview",
                    Description = "Experience durability and rugged design with Blackview smartphones." +
                    " From robust devices to outdoor-friendly models, Blackview offers a range of smartphones that withstand tough conditions." +
                    " Discover features like water resistance, long-lasting batteries, and reliable performance." +
                    " Elevate your mobile adventures with Blackview's thoughtfully crafted smartphones.",
                    Current_Subcategory_Id = new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("06c69235-4012-476e-9daf-6023eaad3bd4"),
                    Name = "Bluetooth wireless headphones",
                    Description = "Cut the cords and embrace freedom with our collection of Bluetooth wireless headphones." +
                    " From over-ear to in-ear options, our curated selection offers convenience and high-quality audio." +
                    " Explore comfortable designs, advanced features like noise cancellation, and long-lasting battery life." +
                    " Elevate your listening experience with our thoughtfully chosen Bluetooth wireless headphones," +
                    " providing the perfect blend of portability and immersive sound for music, calls, and more.",
                    Current_Subcategory_Id = new Guid("d7f7fc67-7e84-4b72-90eb-99ab9a1fe1a8"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("e61649b9-3499-469f-bc75-f9de4857488c"),
                    Name = "TWS wireless headphones",
                    Description = "Experience true wireless freedom with our collection of TWS (True Wireless Stereo) headphones." +
                    " From compact earbuds to stylish charging cases, our curated selection offers seamless connectivity and impressive audio quality." +
                    " Explore comfortable designs, touch controls, and features like noise isolation for an immersive listening experience." +
                    " Elevate your audio journey with our carefully chosen TWS wireless headphones," +
                    " providing the perfect combination of convenience and exceptional sound quality for music, calls, and more.",
                    Current_Subcategory_Id = new Guid("d7f7fc67-7e84-4b72-90eb-99ab9a1fe1a8"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("f4ce55d0-37cb-415c-9a1b-367676a0d696"),
                    Name = "Wired headphones",
                    Description = "Stay connected to your music and calls with our range of reliable wired headphones." +
                    " From classic over-ear designs to comfortable in-ear options, our curated selection prioritizes durability and high-quality audio." +
                    " Explore features like noise isolation and built-in microphones for added convenience." +
                    " Elevate your listening experience with our carefully chosen wired headphones, ensuring a reliable and immersive sound for your music, podcasts, and hands-free communication.",
                    Current_Subcategory_Id = new Guid("d7f7fc67-7e84-4b72-90eb-99ab9a1fe1a8"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("4fe68c8c-130d-471a-bac4-eabd7eab4ee3"),
                    Name = "Protective glass",
                    Description = "Safeguard your device with our collection of protective glass solutions." +
                    " From tempered glass screen protectors to full coverage and anti-glare options, our curated selection offers durable and crystal-clear protection." +
                    " Explore precise fits for various devices, easy installation, and advanced features such as scratch resistance and fingerprint resistance." +
                    " Elevate your device's durability with our thoughtfully chosen protective glass, ensuring a clear and shielded screen for smartphones, tablets, and more.",
                    Current_Subcategory_Id = new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("5eaf8632-b8c7-45c4-b049-70bd6cf34739"),
                    Name = "Wireless energy harvesting device",
                    Description = "Step into the future of sustainable technology with our wireless energy harvesting devices." +
                    " Harnessing ambient energy from the environment, these devices eliminate the need for traditional power sources." +
                    " Explore innovative solutions that convert light, motion, or radio frequency signals into usable power for various applications." +
                    " Elevate your approach to energy efficiency with our curated selection of wireless energy harvesting devices, contributing to a greener and more sustainable future.",
                    Current_Subcategory_Id = new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("7c5cb09e-76ef-4307-9012-fbd1db7e0a26"),
                    Name = "Protective cover",
                    Description = "Guard your device in style with our collection of protective covers." +
                    " From sleek phone cases to durable laptop sleeves, our curated selection offers a blend of fashion and functionality." +
                    " Explore options that prioritize shock absorption, drop protection, and precise fit for various devices." +
                    " Elevate your device's defense with our thoughtfully chosen protective covers, ensuring both style and durability for smartphones, laptops, tablets, and more.",
                    Current_Subcategory_Id = new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("8047875e-f8ea-429c-bef9-5813d22f3a42"),
                    Name = "Wires for energy collection",
                    Description = "Optimize energy harvesting with our collection of wires designed for efficient energy collection." +
                    " From robust cables to specialized wiring solutions, our curated selection caters to various energy-harvesting systems." +
                    " Explore options with high conductivity and durability, ensuring effective transfer of harvested energy." +
                    " Elevate your sustainable energy initiatives with our thoughtfully chosen wires for energy collection," +
                    " providing the essential connectivity for harnessing power from solar, motion, or other sources.",
                    Current_Subcategory_Id = new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("81a2378e-4dd7-4f06-8ff1-8d390afcd4d0"),
                    Name = "Powerbank",
                    Description = "Stay powered on the go with our range of reliable power banks." +
                    " From compact and portable options to high-capacity choices, our curated selection ensures you're always charged and connected." +
                    " Explore features like fast charging, multiple ports, and sleek designs." +
                    " Elevate your mobile experience with our thoughtfully chosen power banks," +
                    " providing a convenient and efficient way to keep your devices charged, whether you're traveling, commuting, or simply on the move.",
                    Current_Subcategory_Id = new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("89ff430a-a0cd-41b7-a803-c47fa04c2569"),
                    Name = "Phone adapters",
                    Description = "Ensure seamless charging with our collection of phone adapters." +
                    " From USB-C to Lightning and micro USB adapters, our curated selection offers compatibility with various devices." +
                    " Explore fast-charging options, compact designs, and durable materials for reliable power delivery." +
                    " Elevate your charging experience with our thoughtfully chosen phone adapters, providing the essential connectivity to keep your devices powered up efficiently and conveniently.",
                    Current_Subcategory_Id = new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("af939c28-8161-411c-a6fe-7193b79e1e6c"),
                    Name = "Selfie sticks",
                    Description = "Capture the perfect moments with our selection of selfie sticks." +
                    " From compact and portable designs to Bluetooth-enabled options," +
                    " our curated collection ensures you can snap photos and record videos with ease." +
                    " Explore adjustable lengths, secure phone mounts, and convenient features for effortless selfies." +
                    " Elevate your photography game with our thoughtfully chosen selfie sticks," +
                    " providing a fun and versatile tool for capturing memories on your own terms.",
                    Current_Subcategory_Id = new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("b18e82d5-c4c5-4295-b9fa-99b82101a58f"),
                    Name = "SD cards",
                    Description = "Expand your storage capacity with our range of SD cards." +
                    " From standard to high-capacity options, our curated selection ensures reliable and fast storage solutions for various devices." +
                    " Explore different storage capacities and read/write speeds to suit your specific needs, whether for cameras, smartphones, or other digital devices." +
                    " Elevate your storage capabilities with our carefully chosen SD cards, providing the essential memory expansion for capturing, storing, and transferring your data seamlessly.",
                    Current_Subcategory_Id = new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("d6211952-48af-4029-95b7-d6fc7844429c"),
                    Name = "Micro cards",
                    Description = "Enhance your device's storage capacity with our selection of microSD cards." +
                    " From standard to high-capacity options, our curated collection offers reliable and fast storage solutions for smartphones, cameras, and other digital devices." +
                    " Explore different storage capacities and read/write speeds to suit your specific needs." +
                    " Elevate your storage capabilities with our thoughtfully chosen microSD cards, providing the essential memory expansion for capturing, storing, and transferring your data seamlessly.",
                    Current_Subcategory_Id = new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("e9281b7d-cb0c-45da-bf83-962bcd4ba656"),
                    Name = "Gamepad for smartphone",
                    Description = "Elevate your mobile gaming experience with our smartphone gamepads." +
                    " From ergonomic designs to customizable controls, our curated selection offers a seamless and immersive gaming experience on your smartphone." +
                    " Explore Bluetooth-enabled options for wireless connectivity and compatibility with a variety of games." +
                    " Elevate your gaming sessions with our thoughtfully chosen smartphone gamepads, providing precision control and enhanced gameplay for a wide range of mobile games.",
                    Current_Subcategory_Id = new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("e59993b4-0e5f-4972-96d6-2b9928af3296"),
                    Name = "Apple",
                    Description = "Explore the world of innovation with Apple's cutting-edge products." +
                    " From the iconic iPhone series to sleek MacBook laptops and powerful iPads, Apple offers a seamless ecosystem of devices." +
                    " Discover high-quality craftsmanship, stunning displays, and user-friendly interfaces that redefine technology." +
                    " Elevate your digital experience with Apple's thoughtfully designed products, ensuring a blend of style, performance, and innovation in every device.",
                    Current_Subcategory_Id = new Guid("1f9db05a-b5cc-4ea7-8e6d-93e12b5b8d5d"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("87f60f99-e88a-4a8b-9269-d67d4cc0106e"),
                    Name = "OPPO",
                    Description = "Dive into the realm of innovation with OPPO's exceptional lineup of smartphones." +
                    " From sleek designs to cutting-edge camera technology, OPPO offers a range of devices that prioritize style and functionality." +
                    " Explore the latest in mobile innovation with OPPO's commitment to delivering impressive features and powerful performance." +
                    " Elevate your mobile experience with OPPO's thoughtfully crafted smartphones, blending style, innovation, and user-friendly design.",
                    Current_Subcategory_Id = new Guid("1f9db05a-b5cc-4ea7-8e6d-93e12b5b8d5d"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("599c9f12-b1c9-4dc0-8854-1af53d3bc2f0"),
                    Name = "Samsung",
                    Description = "Experience the epitome of technology and innovation with Samsung's diverse product range." +
                    " From flagship smartphones like the Galaxy series to smart TVs, home appliances, and cutting-edge wearables, Samsung offers a comprehensive ecosystem." +
                    " Discover stunning displays, powerful performance, and advanced features that redefine the way we live and connect." +
                    " Elevate your digital lifestyle with Samsung's thoughtfully designed products, bringing together quality, innovation, and versatility in every device.",
                    Current_Subcategory_Id = new Guid("1f9db05a-b5cc-4ea7-8e6d-93e12b5b8d5d"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("1201990f-f7fa-486c-a98b-40065fd130cb"),
                    Name = "Xiaomi",
                    Description = "Explore the world of innovation with Xiaomi's diverse range of technology products." +
                    " From feature-packed smartphones and smart home devices to fitness wearables and more, Xiaomi offers a wide array of products that combine quality with affordability." +
                    " Discover cutting-edge technology, sleek designs, and user-friendly interfaces that cater to various aspects of modern living." +
                    " Elevate your tech experience with Xiaomi's thoughtfully crafted products, where innovation meets accessibility.",
                    Current_Subcategory_Id = new Guid("1f9db05a-b5cc-4ea7-8e6d-93e12b5b8d5d"),
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("02b84dde-1ae8-4e03-81f9-c164ef536b19"),
                    Name = "Blackview",
                    Description = "Experience durability and rugged design with Blackview smartphones." +
                    " From robust devices to outdoor-friendly models, Blackview offers a range of smartphones that withstand tough conditions." +
                    " Discover features like water resistance, long-lasting batteries, and reliable performance." +
                    " Elevate your mobile adventures with Blackview's thoughtfully crafted smartphones.",
                    Current_Subcategory_Id = new Guid("1f9db05a-b5cc-4ea7-8e6d-93e12b5b8d5d"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("99554967-268f-461e-854b-9998bc8ef977"),
                    Name = "Energizer",
                    Description = "As of my last knowledge update in January 2022," +
                    " Energizer is primarily known for its batteries and power-related products," +
                    " and there is no widely known information about Energizer producing push-button phones." +
                    " If there have been developments or new product releases since then," +
                    " I recommend checking the latest information from reliable sources or" +
                    " visiting the official Energizer website for the most up-to-date details on their product offerings.",
                    Current_Subcategory_Id = new Guid("23f8c33a-16fc-4eaa-9c3e-b97e130dce9d"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("738e7941-fce5-4fd0-8bc1-a615c67aa73a"),
                    Name = "Nokia",
                    Description = "Nokia is a well-known Finnish multinational telecommunications, information technology, and consumer electronics company." +
                    " Historically, Nokia was a leading mobile phone manufacturer and played a significant role in the early days of the mobile phone industry." +
                    " Nokia phones were widely popular and known for their durability and reliability.",
                    Current_Subcategory_Id = new Guid("23f8c33a-16fc-4eaa-9c3e-b97e130dce9d"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("0f810786-43f5-41f1-929d-89d80b9a9235"),
                    Name = "Apple",
                    Description = "Explore the world of innovation with Apple's cutting-edge products." +
                    " From the iconic iPhone series to sleek MacBook laptops and powerful iPads, Apple offers a seamless ecosystem of devices." +
                    " Discover high-quality craftsmanship, stunning displays, and user-friendly interfaces that redefine technology." +
                    " Elevate your digital experience with Apple's thoughtfully designed products, ensuring a blend of style, performance, and innovation in every device.",
                    Current_Subcategory_Id = new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("14db8bd4-4b22-4726-8058-4b02e2a16b73"),
                    Name = "Samsung",
                    Description = "Experience the epitome of technology and innovation with Samsung's diverse product range." +
                    " From flagship smartphones like the Galaxy series to smart TVs, home appliances, and cutting-edge wearables, Samsung offers a comprehensive ecosystem." +
                    " Discover stunning displays, powerful performance, and advanced features that redefine the way we live and connect." +
                    " Elevate your digital lifestyle with Samsung's thoughtfully designed products, bringing together quality, innovation, and versatility in every device.",
                    Current_Subcategory_Id = new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("838f5b32-13c6-4910-9b43-bb06174d2165"),
                    Name = "HUAWEI",
                    Description = "Immerse yourself in innovation with Huawei's diverse range of technology products." +
                    " From flagship smartphones like the P and Mate series to cutting-edge wearables, laptops, and networking solutions, Huawei offers a comprehensive ecosystem." +
                    " Discover advanced camera technology, powerful performance, and sleek designs that redefine the possibilities of connected living." +
                    " Elevate your digital experience with Huawei's thoughtfully designed products, where innovation, craftsmanship, and efficiency converge.",
                    Current_Subcategory_Id = new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("ca0e67f6-20c4-49f1-8f91-d7cd17e374a3"),
                    Name = "Xiaomi",
                    Description = "Explore the world of innovation with Xiaomi's diverse range of technology products." +
                    " From feature-packed smartphones and smart home devices to fitness wearables and more, Xiaomi offers a wide array of products that combine quality with affordability." +
                    " Discover cutting-edge technology, sleek designs, and user-friendly interfaces that cater to various aspects of modern living." +
                    " Elevate your tech experience with Xiaomi's thoughtfully crafted products, where innovation meets accessibility.",
                    Current_Subcategory_Id = new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("cce8806d-26a8-4601-80e5-acbcfc0dc553"),
                    Name = "AMAZFIT",
                    Description = "Amazfit is a brand of smartwatches and fitness trackers primarily produced by Huami, a Chinese company that specializes in wearable technology." +
                    " Amazfit smartwatches are known for their focus on health and fitness features, as well as stylish designs. ",
                    Current_Subcategory_Id = new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("f8623b5a-756b-4b4e-89ad-3204dd8088d1"),
                    Name = "Kieslect",
                    Description = "Boasting a powerful 2-in-1 calling chip & stable 5.2 Bluetooth connection, Kr Pro provides you an stable, clear and high sound quality phone calls at anytime & anywhere." +
                    " Conveniently receive & reject phone calls, dial out and store up to 100 contacts on your Kr Pro smart watch!",
                    Current_Subcategory_Id = new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("320dfc5c-fb01-45d0-9f93-0b71dcc393b6"),
                    Name = "HUAWEI",
                    Description = "Immerse yourself in innovation with Huawei's diverse range of technology products." +
                    " From flagship smartphones like the P and Mate series to cutting-edge wearables, laptops, and networking solutions, Huawei offers a comprehensive ecosystem." +
                    " Discover advanced camera technology, powerful performance, and sleek designs that redefine the possibilities of connected living." +
                    " Elevate your digital experience with Huawei's thoughtfully designed products, where innovation, craftsmanship, and efficiency converge.",
                    Current_Subcategory_Id = new Guid("07ff4b23-b509-41e2-b932-37eae200181c"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("8b282235-99da-449e-a0ca-c0a755cf5087"),
                    Name = "Xiaomi",
                    Description = "Explore the world of innovation with Xiaomi's diverse range of technology products." +
                    " From feature-packed smartphones and smart home devices to fitness wearables and more, Xiaomi offers a wide array of products that combine quality with affordability." +
                    " Discover cutting-edge technology, sleek designs, and user-friendly interfaces that cater to various aspects of modern living." +
                    " Elevate your tech experience with Xiaomi's thoughtfully crafted products, where innovation meets accessibility.",
                    Current_Subcategory_Id = new Guid("07ff4b23-b509-41e2-b932-37eae200181c"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("aacd89bd-f53a-40e6-8cb5-045ac969da2d"),
                    Name = "Blackview",
                    Description = "Experience durability and rugged design with Blackview smartphones." +
                    " From robust devices to outdoor-friendly models, Blackview offers a range of smartphones that withstand tough conditions." +
                    " Discover features like water resistance, long-lasting batteries, and reliable performance." +
                    " Elevate your mobile adventures with Blackview's thoughtfully crafted smartphones.",
                    Current_Subcategory_Id = new Guid("07ff4b23-b509-41e2-b932-37eae200181c"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("fc34b77b-6812-41fa-b942-998c92a77854"),
                    Name = "Q&Q ",
                    Description = "Enhance your fitness journey with Q&Q Smart Bracelets." +
                    " Track activities, monitor health metrics, and stay connected in style with these innovative and functional wearables.",
                    Current_Subcategory_Id = new Guid("07ff4b23-b509-41e2-b932-37eae200181c"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("1f875c75-491b-44e2-976e-a5c4e06c6d93"),
                    Name = "Management hub",
                    Description = "Optimize control and efficiency with a Management Hub." +
                    " Streamline operations, monitor performance," +
                    " and make informed decisions seamlessly from this centralized management solution.",
                    Current_Subcategory_Id = new Guid("8d60aefa-e6cb-4b90-9e90-0de7d4d01a7b"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("1f92ffa3-5a8e-4eab-a776-b0ced62195fb"),
                    Name = "Sensors",
                    Description = "Empower your devices with precision using advanced Sensors." +
                    " From motion detection to environmental monitoring, our sensors deliver accurate data for enhanced functionality and automation.",
                    Current_Subcategory_Id = new Guid("8d60aefa-e6cb-4b90-9e90-0de7d4d01a7b"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("2d4efe70-0f73-40ed-a431-0cecb3fe8601"),
                    Name = "Lighting",
                    Description = "Illuminate intelligently with Smart Lighting." +
                    " Customize ambiance, control remotely, and save energy through innovative, connected lighting solutions for modern living spaces.",
                    Current_Subcategory_Id = new Guid("8d60aefa-e6cb-4b90-9e90-0de7d4d01a7b"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("38e612bc-d08a-49e7-bba7-e89b99860825"),
                    Name = "IP video surveillance cameras",
                    Description = "Ensure security with IP Video Surveillance Cameras." +
                    " Experience high-definition monitoring, remote access," +
                    " and advanced features for comprehensive and reliable video surveillance in any environment.",
                    Current_Subcategory_Id = new Guid("8d60aefa-e6cb-4b90-9e90-0de7d4d01a7b"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("acb0d8a7-79b7-44d8-8082-c786ccddc5d7"),
                    Name = "Smart locks",
                    Description = "Upgrade security effortlessly with Smart Locks." +
                    " Enjoy keyless entry, remote control, and personalized access," +
                    " enhancing convenience and peace of mind in your connected home or business.",
                    Current_Subcategory_Id = new Guid("8d60aefa-e6cb-4b90-9e90-0de7d4d01a7b"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("af4df39e-8846-4424-a3f4-2fd70333485b"),
                    Name = "Smart electrical sockets",
                    Description = "Effortlessly manage your devices with Smart Electrical Sockets." +
                    " Control remotely, set schedules, and monitor energy usage for a smarter, more efficient home or office environment.",
                    Current_Subcategory_Id = new Guid("8d60aefa-e6cb-4b90-9e90-0de7d4d01a7b"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("c1abc056-125a-4dc6-b953-620eb65fdea2"),
                    Name = "Intercoms",
                    Description = "Enhance communication with Intercom Systems." +
                    " Streamline interactions, monitor entrances," +
                    " and ensure seamless connectivity for secure and efficient communication within your home or business.",
                    Current_Subcategory_Id = new Guid("8d60aefa-e6cb-4b90-9e90-0de7d4d01a7b"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("e7c9d156-dd96-42bb-b6a0-1884a3a5009f"),
                    Name = "Smart electric switches",
                    Description = "Transform your home with Smart Electric Switches." +
                    " Enjoy remote control, voice activation, and scheduling features for convenient" +
                    " and energy-efficient lighting and appliance management.",
                    Current_Subcategory_Id = new Guid("8d60aefa-e6cb-4b90-9e90-0de7d4d01a7b"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("89e8df38-d10f-4d21-b688-03adde4890b3"),
                    Name = "Bluetooth wireless headphones",
                    Description = "Experience wireless freedom with Bluetooth Wireless Headphones." +
                    " Immerse yourself in high-quality sound, hands-free convenience," +
                    " and stylish designs for an elevated audio experience on the go.",
                    Current_Subcategory_Id = new Guid("b0f7748c-02cf-46e3-9c82-412c284240d1"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("e041cb2a-39b1-4ee1-95bb-60b806a99822"),
                    Name = "TWS wireless headphones",
                    Description = "Experience true wireless freedom with our collection of TWS (True Wireless Stereo) headphones." +
                    " From compact earbuds to stylish charging cases, our curated selection offers seamless connectivity and impressive audio quality." +
                    " Explore comfortable designs, touch controls, and features like noise isolation for an immersive listening experience." +
                    " Elevate your audio journey with our carefully chosen TWS wireless headphones," +
                    " providing the perfect combination of convenience and exceptional sound quality for music, calls, and more.",
                    Current_Subcategory_Id = new Guid("b0f7748c-02cf-46e3-9c82-412c284240d1"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("a00e3c68-146c-42a9-b794-0538a68c0cc2"),
                    Name = "Wired headphones",
                    Description = "Stay connected to your music and calls with our range of reliable wired headphones." +
                    " From classic over-ear designs to comfortable in-ear options, our curated selection prioritizes durability and high-quality audio." +
                    " Explore features like noise isolation and built-in microphones for added convenience." +
                    " Elevate your listening experience with our carefully chosen wired headphones, ensuring a reliable and immersive sound for your music, podcasts, and hands-free communication.",
                    Current_Subcategory_Id = new Guid("b0f7748c-02cf-46e3-9c82-412c284240d1"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("1a39bd74-4a89-43df-9fd9-b34710b1d221"),
                    Name = "Electric scooters",
                    Description = "Embrace eco-friendly commuting with Electric Scooters." +
                    " Effortlessly navigate urban landscapes, enjoy efficient travel," +
                    " and reduce your carbon footprint with these sleek and agile electric vehicles.",
                    Current_Subcategory_Id = new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("28f7b326-391f-407c-9fb8-ec4b6458ddd5"),
                    Name = "Mopeds",
                    Description = "Navigate city streets with ease using Mopeds." +
                    " Combining efficiency with style, these compact two-wheelers offer a convenient and eco-friendly solution for urban commuting.",
                    Current_Subcategory_Id = new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("380d07fd-a2a4-4477-ab6f-7b95fafb0c88"),
                    Name = "Battery motorcycles",
                    Description = "Ride into the future with Battery Motorcycles." +
                    " Silent, eco-friendly, and efficient, these electric two-wheelers provide a thrilling and sustainable alternative for urban commuting and beyond.",
                    Current_Subcategory_Id = new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("3b23c2f5-658a-4dc7-90d3-d5349c7cf6ef"),
                    Name = "Gyroboards",
                    Description = "Experience futuristic transportation with Gyroboards." +
                    " Effortlessly glide and maneuver, mastering the art of balance for a fun and efficient way to commute in urban environments.",
                    Current_Subcategory_Id = new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("4a51d1c9-2415-4eb4-8aae-a5bf732ddd89"),
                    Name = "Electric cars",
                    Description = "Drive into the future with Electric Cars." +
                    " Experience sustainable mobility, zero emissions, and cutting-edge technology for a greener and smarter approach to commuting.",
                    Current_Subcategory_Id = new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("aba63da0-0281-413b-9148-f68e2e0275cc"),
                    Name = "Electric skates",
                    Description = "Unleash excitement with Electric Skates." +
                    " Effortlessly glide, accelerate, and brake with these motorized wonders," +
                    " offering a thrilling and dynamic way to explore your surroundings.",
                    Current_Subcategory_Id = new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("b0823bd2-809c-4e25-bfb4-db44fe708dc8"),
                    Name = "Motorcycles",
                    Description = "Embrace the open road with Motorcycles." +
                    " Experience freedom, speed, and the thrill of the ride on these powerful and iconic two-wheelers.",
                    Current_Subcategory_Id = new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("dc0f0d97-95e1-478f-b6d9-2562e00d2193"),
                    Name = "Quad bike",
                    Description = "Conquer off-road adventures with a Quad Bike." +
                    " Experience versatility, power, and adrenaline as you navigate challenging terrains with this all-terrain vehicle.",
                    Current_Subcategory_Id = new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("0d2689e3-cce8-4ef7-b152-a193594a0e0e"),
                    Name = "Apple",
                    Description = "Explore the world of innovation with Apple's cutting-edge products." +
                    " From the iconic iPhone series to sleek MacBook laptops and powerful iPads, Apple offers a seamless ecosystem of devices." +
                    " Discover high-quality craftsmanship, stunning displays, and user-friendly interfaces that redefine technology." +
                    " Elevate your digital experience with Apple's thoughtfully designed products, ensuring a blend of style, performance, and innovation in every device.",
                    Current_Subcategory_Id = new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("15a950de-af6e-4f43-9ad0-f25fcb42e8ab"),
                    Name = "HP",
                    Description = "Discover cutting-edge technology with HP products." +
                    " From powerful laptops to innovative printers," +
                    " HP offers reliable solutions for both personal and professional computing needs.",
                    Current_Subcategory_Id = new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("1a97e5e2-07b6-4388-bce0-c16c99e3262a"),
                    Name = "MSI",
                    Description = "Elevate your gaming and computing experience with MSI." +
                    " Known for high-performance laptops, motherboards, and graphics cards," +
                    " MSI delivers cutting-edge technology and sleek design.",
                    Current_Subcategory_Id = new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("592c0caf-47ac-4095-a39d-b7ffbd4ec886"),
                    Name = "Acer",
                    Description = "Experience innovation and reliability with Acer." +
                    " From powerful laptops to sleek monitors," +
                    " Acer offers a diverse range of technology solutions for work, play, and creativity.",
                    Current_Subcategory_Id = new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("68db1da6-3858-4d97-a42b-359c0ad8e332"),
                    Name = "HUAWEI",
                    Description = "Immerse yourself in innovation with Huawei's diverse range of technology products." +
                    " From flagship smartphones like the P and Mate series to cutting-edge wearables, laptops, and networking solutions, Huawei offers a comprehensive ecosystem." +
                    " Discover advanced camera technology, powerful performance, and sleek designs that redefine the possibilities of connected living." +
                    " Elevate your digital experience with Huawei's thoughtfully designed products, where innovation, craftsmanship, and efficiency converge.",
                    Current_Subcategory_Id = new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("8505c965-4e9d-4726-bf56-9be79d7d61e3"),
                    Name = "Lenovo",
                    Description = "Empower your digital journey with Lenovo." +
                    " From versatile laptops to cutting-edge PCs and smart devices," +
                    " Lenovo delivers innovation, performance, and reliability for a connected world.",
                    Current_Subcategory_Id = new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("ab334357-7842-4f11-82e9-91706f1cd590"),
                    Name = "Asus",
                    Description = "Dive into innovation with ASUS." +
                    " Known for cutting-edge laptops, motherboards," +
                    " and gaming peripherals, ASUS combines performance and style to enhance your digital lifestyle.",
                    Current_Subcategory_Id = new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("e9e58617-65d6-4eec-9ec6-64b51559059d"),
                    Name = "Dell",
                    Description = "Transform your computing experience with Dell." +
                    " From powerful laptops to versatile desktops and premium monitors," +
                    " Dell delivers reliable technology solutions for work and play.",
                    Current_Subcategory_Id = new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("c3f97827-5dca-4a53-9432-247321f407e5"),
                    Name = "Honor",
                    Description = "Discover the perfect blend of style and performance with Honor." +
                    " From feature-packed smartphones to smartwatches," +
                    " Honor delivers innovative technology for the digital-savvy lifestyle.",
                    Current_Subcategory_Id = new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("c3f67823-5dca-4a53-9432-247321f107e5"),
                    Name = "System blocks",
                    Description = "Build your computing powerhouse with System Blocks." +
                    " Customize performance, expandability," +
                    " and style as you create a tailored PC to meet your specific needs and preferences.",
                    Current_Subcategory_Id = new Guid("6f1d8a61-5b88-4e67-a11f-651b3d09a432"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("c3f67629-5dca-4a53-9432-247321f507e5"),
                    Name = "Monoblocks",
                    Description = "Simplify your computing setup with Monoblocks." +
                    " Combining a sleek display and powerful components," +
                    " these all-in-one solutions offer efficiency and style for a streamlined desktop experience.",
                    Current_Subcategory_Id = new Guid("6f1d8a61-5b88-4e67-a11f-651b3d09a432"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("10fd68cf-6503-4f17-9cb5-0b157093b4d0"),
                    Name = "Samsung",
                    Description = "Explore cutting-edge technology with Samsung." +
                    " From innovative smartphones to high-quality home appliances," +
                    " Samsung delivers reliability, style, and innovation for modern lifestyles.",
                    Current_Subcategory_Id = new Guid("2d61c82b-9ba7-4528-9e14-d8de745f32b3"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("536bf179-64e7-4fd4-a944-1ad6a33ef352"),
                    Name = "Asus",
                    Description = "Dive into innovation with ASUS." +
                    " Known for cutting-edge laptops, motherboards," +
                    " and gaming peripherals, ASUS combines performance and style to enhance your digital lifestyle.",
                    Current_Subcategory_Id = new Guid("2d61c82b-9ba7-4528-9e14-d8de745f32b3"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("900c0cfb-12e2-4917-a69e-741271adb6ae"),
                    Name = "HP",
                    Description = "Unleash possibilities with HP." +
                    " From powerful laptops to innovative printers," +
                    " HP provides reliable technology solutions for both personal and professional computing needs.",
                    Current_Subcategory_Id = new Guid("2d61c82b-9ba7-4528-9e14-d8de745f32b3"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("a039a892-bf21-440b-869f-d8ee4155d18c"),
                    Name = "Dell",
                    Description = "Transform your computing experience with Dell." +
                    " From powerful laptops to versatile desktops and premium monitors," +
                    " Dell delivers reliable technology solutions for work and play.",
                    Current_Subcategory_Id = new Guid("2d61c82b-9ba7-4528-9e14-d8de745f32b3"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                },
                new Deepcategory
                {
                    Id = new Guid("f6afa27e-a06c-457e-bbad-9d536eedca4d"),
                    Name = "Philips",
                    Description = "Experience quality and innovation with Philips." +
                    " From advanced healthcare technology to consumer electronics," +
                    " Philips delivers solutions that enhance well-being and simplify everyday life.",
                    Current_Subcategory_Id = new Guid("2d61c82b-9ba7-4528-9e14-d8de745f32b3"),
                    CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2024, 1, 13, 0, 0, 0, DateTimeKind.Utc)
                }
                //Subcategories of Smartphones and accessories
            );
            #endregion

            #region Color seeding...
            modelBuilder.Entity<Color>().HasData
            (
                new Color
                {
                    Id = new Guid("4b24804b-9a8f-4d33-9f43-8c461e4dbf11"),
                    Color_Code = "#000000",
                    Name = "black",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Color
                {
                    Id = new Guid("9c327764-bf90-4b8b-8c38-370cb3aa2a5a"),
                    Color_Code = "#ffffff",
                    Name = "white",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Color
                {
                    Id = new Guid("8a4c94f8-2437-4e89-9075-56bbcf19c0e9"),
                    Color_Code = "#a52a2a",
                    Name = "brown",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Color
                {
                    Id = new Guid("af15118a-95ac-487a-b103-c9a0a1918c25"),
                    Color_Code = "#0000ff",
                    Name = "blue",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Color
                {
                    Id = new Guid("6c1d50fc-b6eb-4d76-ba7e-81a7811ea15f"),
                    Color_Code = "#ff0000",
                    Name = "red",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Color
                {
                    Id = new Guid("3e20ac3a-c156-4f60-b0b4-e1f1c205e24d"),
                    Color_Code = "#808080",
                    Name = "gray",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Color
                {
                    Id = new Guid("db1ef4d9-5b95-41a3-8bfb-7f01f8a50f32"),
                    Color_Code = "#008000",
                    Name = "green",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Color
                {
                    Id = new Guid("45e0cbf9-aa2a-44a4-93a1-bf4d3aa623ce"),
                    Color_Code = "#ffff00",
                    Name = "yellow",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Color
                {
                    Id = new Guid("8640c057-8997-4b16-b3dd-7c3d3c2e1a12"),
                    Color_Code = "#2f4f4f",
                    Name = "darkslategray",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Color
                {
                    Id = new Guid("7a9d04e8-1a22-4aae-8232-62f5a0c28b87"),
                    Color_Code = "#663399",
                    Name = "rebeccapurple",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Color
                {
                    Id = new Guid("2ff83d6b-6c95-4f7d-9c64-60e406a057a1"),
                    Color_Code = "#ffe4c4",
                    Name = "bisque",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Color
                {
                    Id = new Guid("9a305d7f-5c8f-4fe1-9c0d-d8a8eb4a17c3"),
                    Color_Code = "#ffe4c4",
                    Name = "bisque",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Color
                {
                    Id = new Guid("c80a742d-12db-4a19-a0e8-44c67f7fb21a"),
                    Color_Code = "#00ced1",
                    Name = "darkturquoise",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                }
            );
            #endregion

            #region Size seeding...

            modelBuilder.Entity<Size>().HasData
            (
                new Size
                {
                    Id = new Guid("8bd829a6-34ba-44a7-8b4d-0ad93f90d484"),
                    Name = "XXS",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Size
                {
                    Id = new Guid("eb3f62f7-cc00-4398-8f29-3c517fb1f6c7"),
                    Name = "XS",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Size
                {
                    Id = new Guid("9041cdfa-244d-4f0d-bbd1-704f28c406a2"),
                    Name = "S",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Size
                {
                    Id = new Guid("5b1dfdff-da43-4d89-a7c4-b70ea1059f11"),
                    Name = "M",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Size
                { 
                    Id = new Guid("df31d3cc-7b41-43f0-af17-125cdd195c3f"),
                    Name="L",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Size
                {
                    Id = new Guid("13fd75d0-496f-49cb-bb8c-b7bd75b81d74"),
                    Name = "XL",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Size
                {
                    Id = new Guid("ac49680d-c4d1-49c0-a73c-55fb4eeeec78"),
                    Name = "XXL",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                }
            );

            #endregion

            #region Warranty seeding...

            modelBuilder.Entity<Warranty>().HasData
            (
                new Warranty
                {
                    Id = new Guid("da9360f7-4c2d-495a-b8d1-514f700000a9"),
                    Name = "Manufacturer's Warranty",
                    Description = "Provided by the manufacturer or brand, this type of warranty typically covers the product against specific defects for a certain period." +
                    " In case of product failure, the manufacturer warranty may offer free repair or replacement service.",
                    ExpireYear = 1,
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Warranty
                {
                    Id = new Guid("a23d7953-d26c-445a-a094-9dfb4803db32"),
                    Name = "Seller's Warranty",
                    Description = " Offered by the seller, this type of warranty assures protection against specific defects for a certain duration." +
                    " Also known as a store warranty, it remains valid regardless of where the product was purchased.",
                    ExpireYear = 1,
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Warranty
                {
                    Id = new Guid("2bc1d548-e721-4c4a-a866-607b1697f792"),
                    Name = "Extended Warranty",
                    Description = "Some sellers or manufacturers may offer extended warranty options, extending the standard warranty period." +
                    " This provides additional protection after the expiration of the standard warranty period, usually for an extra fee.",
                    ExpireYear = 2,
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Warranty
                {
                    Id = new Guid("befd7bb6-29aa-46c0-b5dd-3047456eafa5"),
                    Name = "Statutory Warranty",
                    Description = "A statutory warranty is based on laws that dictate certain standards a product must meet for a specific period." +
                    " It's intended to protect consumer rights and is generally valid throughout the expected lifespan of the product.",
                    ExpireYear = 2,
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Warranty
                {
                    Id = new Guid("aee92391-3cbf-41f3-9d9d-95fee80b0c6d"),
                    Name = "Parts Warranty",
                    Description = "This type of warranty covers specific parts of a product." +
                    " For example, separate warranties might be provided for certain parts of a car, such as the engine or transmission.",
                    ExpireYear = 2,
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Warranty
                {
                    Id = new Guid("00f0c335-f171-49b1-85c2-b506f51f4919"),
                    Name = "Gold Warranty",
                    Description = "This type of warranty covers specific parts of a product." +
                    " For example, separate warranties might be provided for certain parts of a car, such as the engine or transmission.",
                    ExpireYear = 5,
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Warranty
                {
                    Id = new Guid("29b6f35a-db7c-43f6-bb3b-5d0a2bd794d6"),
                    Name = "V.I.P. Warranty",
                    Description = "This type of warranty covers specific parts of a product." +
                    " For example, separate warranties might be provided for certain parts of a car, such as the engine or transmission.",
                    ExpireYear = 5,
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                }
            );

            #endregion

            #region Store seeding...

            modelBuilder.Entity<Store>().HasData
            (
                new Store
                {
                    Id = new Guid("2e710c0d-f9cd-4f36-b4ee-37db6d663dc9"),
                    Name = "Fullerton",
                    Address = "1100 S Harbor Blvd, Fullerton, CA 92832, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                { 
                    Id = new Guid("f2965119-f9c2-4e43-91be-1497fd84cfbc"),
                    Name = "Irvine",
                    Address = "13672 Jamboree Rd, Irvine, CA 92602, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("b3997060-302a-42af-9538-bdd4a8d38146"),
                    Name = "Long Beach",
                    Address = "6235 E Spring St, Long Beach, CA 90808, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("9bcfc1ee-6718-447d-a1a3-487c4273fede"),
                    Name = "Los Angeles - Ladera Heights",
                    Address = "6855 S La Cienega Blvd, Los Angeles, CA 90045, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("b9154194-71ad-45d4-984e-c250d3bb3017"),
                    Name = "North Hollywood",
                    Address = "5101 Lankershim Blvd, North Hollywood, CA 91601, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("974ccf65-52f1-4fcc-add3-47e7376deea6"),
                    Name = "Northridge",
                    Address = "19340 Rinaldi St, Northridge, CA 91326, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("b8ebfcad-62c0-4ad8-abd4-74e71792fee7"),
                    Name = "Whittier",
                    Address = "15225 Whittier Blvd, Whittier, CA 90603, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("672bae49-d39c-42f4-9e68-15fc73f5671f"),
                    Name = "Woodland Hills",
                    Address = "6245 CA-27, Woodland Hills, CA 91367, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("1a8820b1-488f-4720-b7a7-647f9f69f7c8"),
                    Name = "Cerritos",
                    Address = "11340 South St, Cerritos, CA 90703, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("4ebb2028-7c05-41a6-80e2-fbc4812bdf2a"),
                    Name = "La Habra",
                    Address = "1610 W Imperial Hwy Ste 200, La Habra, CA 90631, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("5cd241db-8bf2-4d59-a9a6-adc0c8862744"),
                    Name = "Moorpark",
                    Address = "742 Los Angeles Ave, Moorpark, CA 93021, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("ae7dba7c-1759-4550-8058-d31519a770ca"),
                    Name = "Mission Viejo",
                    Address = "26940 Crown Valley Pkwy, Mission Viejo, CA 92691, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("e08e2464-6753-4efd-90b6-d74e91152a70"),
                    Name = "La Verne",
                    Address = "2229 Foothill Blvd, La Verne, CA 91750, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("0bdabb75-6a32-4201-8f25-b34b4ead47c5"),
                    Name = "Murrieta",
                    Address = "40481 Murrieta Hot Springs Rd, Murrieta, CA 92563, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("751fe878-76d2-408e-9182-e1220a7372ac"),
                    Name = "Huntington Beach",
                    Address = "6811 Warner Ave, Huntington Beach, CA 92647, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                { 
                    Id = new Guid("466c2a14-1b49-4df2-8805-3b7cfe296f4b"),
                    Name = "Encino",
                    Address = "16325 Ventura Blvd, Encino, CA 91436, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("577b69ad-9ec9-45de-8f83-c3b6765e2525"),
                    Name = "Westlake Village",
                    Address = "140 Promenade Way Thousand Oaks, CA 91362",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("7fd60b2c-a704-4e79-84bc-dfcddf3cf495"),
                    Name = "Pasadena",
                    Address = "3425 E Colorado Blvd, Pasadena, CA 91107, United States",
                    Phone_Number = "+18002500668",
                    State = "CALIFORNIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("e0f3067a-ce4b-4a1b-b345-8d113e3fb0a7"),
                    Name = "Bloomingdale",
                    Address = "404 W Army Trail Rd, Bloomingdale, IL 60108, United States",
                    Phone_Number = "+18002500668",
                    State = "ILLINOIS",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("192b3df2-6d78-4ff1-9b3c-50d0de1051d5"),
                    Name = "Naperville",
                    Address = "3116 Illinois Rte 59 Ste #104, Naperville, IL 60564, United States",
                    Phone_Number = "+18002500668",
                    State = "ILLINOIS",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("4ec05f08-5235-42fe-99b6-bc12cdb73680"),
                    Name = "Oak Lawn",
                    Address = "4031 W 95th St, Oak Lawn, IL 60453, United States",
                    Phone_Number = "+18002500668",
                    State = "ILLINOIS",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("3089c262-f54e-4f4a-8a1e-31bc3454a460"),
                    Name = "Schaumburg",
                    Address = "16 A E Golf Rd, Schaumburg, IL 60173, United States",
                    Phone_Number = "+18002500668",
                    State = "ILLINOIS",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                { 
                    Id = new Guid("78eda735-b162-4db7-9986-9e77364ee786"),
                    Name = "Westmont",
                    Address = "30 W 63rd St, Westmont, IL 60559, United States",
                    Phone_Number = "+18002500668",
                    State = "ILLINOIS",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("45e40f90-50a3-4654-8ddf-1a1fbef4c86c"),
                    Name = "Morton Grove",
                    Address = "6939 Dempster St, Morton Grove, IL 60053, United States",
                    Phone_Number = "+18002500668",
                    State = "ILLINOIS",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("598e21f5-65e8-41ab-a8bb-7467b97a83d7"),
                    Name = "Naperville - Ogden",
                    Address = "1351 E Ogden Ave, Naperville, IL 60563, United States",
                    Phone_Number = "+18002500668",
                    State = "ILLINOIS",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("1f5b3eb3-e5eb-4d09-a15c-47736c12bab7"),
                    Name = "North Riverside Harlem",
                    Address = "7201 W 24th St, North Riverside, IL 60546, United States",
                    Phone_Number = "+18002500668",
                    State = "ILLINOIS",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("e2017c16-ed2f-4b1b-9aa5-d870645c6aa7"),
                    Name = "Norridge",
                    Address = "4211 N Harlem Ave, Norridge, IL 60706, United States",
                    Phone_Number = "+18002500668",
                    State = "ILLINOIS",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("ff9e1838-f134-4671-8cfb-008e91de11ea"),
                    Name = "Oceanside",
                    Address = "3620 Long Beach Rd, Oceanside, NY 11572, United States",
                    Phone_Number = "+18002500668",
                    State = "NEW YORK",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("b30dcd36-4946-41f1-8145-315168dc6450"),
                    Name = "Chevy Chase",
                    Address = "5463 Wisconsin Ave, Chevy Chase, MD 20815, United States",
                    Phone_Number = "+18002500668",
                    State = "MARYLAND",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("fe7b900a-fe4c-4f67-b967-6f8d4faa0cdb"),
                    Name = "Chevy Chase - Lake Terrace",
                    Address = "5463 Wisconsin Ave, Chevy Chase - Lake Terrace, MD 20815, United States",
                    Phone_Number = "+18002500668",
                    State = "MARYLAND",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("96cfa05c-a8a4-43c1-97b9-605bbc0c6f49"),
                    Name = "Warrington",
                    Address = "389 Easton Rd, Warrington, PA 18976, United States",
                    Phone_Number = "+18002500668",
                    State = "PENNSYLVANIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("78a284d4-f35e-4cbe-b927-b557bbe27682"),
                    Name = "Broomall",
                    Address = "2924 Springfield Rd, Broomall, PA 19008, United States",
                    Phone_Number = "+18002500668",
                    State = "PENNSYLVANIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("c6040b82-7df7-4a6e-9519-98c93f04e8f2"),
                    Name = "Franconia",
                    Address = "7005 Manchester Blvd, Franconia, VA 22310, United States",
                    Phone_Number = "+18002500668",
                    State = "VIRGINIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("df0abae4-94ef-4529-947b-c17e491f6865"),
                    Name = "Fairfax",
                    Address = "10360 Fairfax Blvd, Fairfax, VA 22030, United States",
                    Phone_Number = "+18002500668",
                    State = "VIRGINIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("c10d56c2-86b7-4458-a403-94a8f7f7bfe5"),
                    Name = "Manassas",
                    Address = "at 7-Eleven, 9056 Liberia Ave, Manassas, VA 20110, United States",
                    Phone_Number = "+18002500668",
                    State = "VIRGINIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("c85cab4a-4173-4dbc-a42c-b0fcd42c084d"),
                    Name = "Lorton",
                    Address = "9409 Lorton Market St, Lorton, VA 22079, United States",
                    Phone_Number = "+18002500668",
                    State = "VIRGINIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("499f4d09-6c58-408e-ac8a-06eb9ff17f6d"),
                    Name = "Arlington",
                    Address = "1550 Crystal Dr, Arlington, VA 22202, United States",
                    Phone_Number = "+18002500668",
                    State = "VIRGINIA",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("2bf29450-24fb-4498-8408-21fb24283062"),
                    Name = "AVA Capitol Hill",
                    Address = "610 E Pike St, Seattle, WA 98122, United States",
                    Phone_Number = "+18002500668",
                    State = "WASHINGTON STATE",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("7b19420e-42b2-4c30-80c0-89ace1329ea0"),
                    Name = "Factoria",
                    Address = "3901 Factoria Square Mall SE, Bellevue, WA 98006, United States",
                    Phone_Number = "+18002500668",
                    State = "WASHINGTON STATE",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("f0fa7eb6-6c54-4f18-bc89-15e541e792aa"),
                    Name = "Seattle - Jackson St",
                    Address = "2301 S Jackson St, Seattle, WA 98144, United States",
                    Phone_Number = "+18002500668",
                    State = "WASHINGTON STATE",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("c4677cb2-1ae4-420c-b989-fcae530c97fe"),
                    Name = "Seattle - Aurora",
                    Address = "13205 Aurora Ave N, Seattle, WA 98133, United States",
                    Phone_Number = "+18002500668",
                    State = "WASHINGTON STATE",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("2c65e1af-7afc-4c76-b2c7-c0a58cefe765"),
                    Name = "Federal Way",
                    Address = "1701 S Commons, Federal Way, WA 98003, United States",
                    Phone_Number = "+18002500668",
                    State = "WASHINGTON STATE",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("0aa85fc2-699f-4fd7-8c38-e70ae3148b22"),
                    Name = "Logan Circle",
                    Address = "1733 14th St NW, Washington, DC 20009, United States",
                    Phone_Number = "+18002500668",
                    State = "WASHINGTON DC",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                },
                new Store
                {
                    Id = new Guid("22f41d38-c1b7-4448-a9ae-fd9abe96d4df"),
                    Name = "Paramus",
                    Address = "30 E Ridgewood Ave, Paramus, NJ 07652, United States",
                    Phone_Number = "+18002500668",
                    State = "NEW JERSEY",
                    CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                    LastUpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, DateTimeKind.Utc)
                }
            );

            #endregion
        }
        public DbSet<RandomPassword> Passwords { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Deepcategory> Deepcategories { get; set; }
        public DbSet<Store> Stores { get; set; }    
        public DbSet<Size> Sizes { get; set; }  
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ActivationToken> ActivationTokens { get; set; }
        public DbSet<Email> Emails { get; set; } 
        public DbSet<Warranty> Warranties { get; set; }
        public DbSet<ProductWarranty> ProductWarranties { get; set; }   
        public DbSet<ProductColor> ProductColors { get; set; }  
        public DbSet<ProductSize> ProductSizes { get; set; }    
        public DbSet<ProductStore> ProductStores { get; set; }  
    }
}
