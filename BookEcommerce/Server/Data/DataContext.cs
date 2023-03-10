namespace BookEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
                .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                   new ProductType { Id = 1, Name = "Default" },
                   new ProductType { Id = 2, Name = "Paperback" },
                   new ProductType { Id = 3, Name = "E-Book" },
                   new ProductType { Id = 4, Name = "Audiobook" },
                   new ProductType { Id = 5, Name = "Stream" },
                   new ProductType { Id = 6, Name = "Blu-ray" },
                   new ProductType { Id = 7, Name = "VHS" },
                   new ProductType { Id = 8, Name = "PC" },
                   new ProductType { Id = 9, Name = "PlayStation" },
                   new ProductType { Id = 10, Name = "Xbox" }
               );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                 new Category
                 {
                     Id = 2,
                     Name = "Stories",
                     Url = "stories"
                 },
                  new Category
                  {
                      Id = 3,
                      Name = "Dramma",
                      Url = "dramma"
                  }
                );

            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "Harry Potter và Hòn đá Phù thủy",
                     Description = "Harry Potter và Hòn đá Phù thủy (nguyên tác: Harry Potter and the Philosopher's Stone) là tiểu thuyết kỳ ảo của văn sĩ người Anh J. K. Rowling. Đây là cuốn đầu trong loạt tiểu thuyết Harry Potter và là tiểu thuyết đầu tay của J. K. Rowling. Nội dung sách kể về Harry Potter, một phù thủy thiếu niên chỉ biết về tiềm năng phép thuật của mình sau khi nhận thư mời nhập học tại Học viện Ma thuật và Pháp thuật Hogwarts vào đúng vào dịp sinh nhật thứ mười một. Ngay năm học đầu tiên, Harry đã có những người bạn thân lẫn những đối thủ ở trường như Ron, Hermione, Draco,.... Được bạn bè giúp sức, Harry chiến đấu chống lại sự trở lại của Chúa tể Hắc ám Voldemort, kẻ đã sát hại cha mẹ cậu nhưng lại thảm bại khi toan giết Harry dù cậu khi đó chỉ mới 15 tháng tuổi.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/5/51/Harry_Potter_v%C3%A0_H%C3%B2n_%C4%91%C3%A1_ph%C3%B9_th%E1%BB%A7y_b%C3%ACa_2003.jpeg",
                     CategoryId = 1,
                     Featured = true
                 },
                 new Product
                 {
                     Id = 2,
                     Title = "Harry Potter và Phòng chứa Bí mật",
                     Description = "Harry Potter và Phòng chứa Bí mật (tiếng Anh: Harry Potter and the Chamber of Secrets) là quyển thứ hai trong loạt truyện Harry Potter của J. K. Rowling. Truyện được phát hành bằng tiếng Anh tại Anh, Hoa Kỳ và nhiều nước khác vào ngày 2 tháng 7 năm 1998. Đến tháng 12 năm 2006 riêng tại Mỹ đã có khoảng 14.9 triệu bản được tiêu thụ. Bản dịch tiếng Việt được nhà văn Lý Lan dịch và xuất bản bởi Nhà xuất bản Trẻ thành 8 tập, in thành sách tháng 2 năm 2001.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/6/62/Harry_Potter_v%C3%A0_Ph%C3%B2ng_ch%E1%BB%A9a_b%C3%AD_m%E1%BA%ADt.jpg",
                     CategoryId = 1,
                 },
                 new Product
                 {
                     Id = 3,
                     Title = "Harry Potter và tên tù nhân ngục Azkaban",
                     Description = "Harry Potter và tên tù nhân ngục Azkaban (tiếng Anh: Harry Potter and the Prisoner of Azkaban) là một quyển tiểu thuyết thuộc thể loại giả tưởng kỳ ảo được viết bởi văn sĩ người Anh J. K. Rowling, đây cũng là tập thứ 3 trong bộ truyện Harry Potter. Quyển sách theo chân Harry Potter, cậu phù thủy nhỏ, trong năm học thứ ba của mình tại Trường Phù thủy và Pháp sư Hogwarts. Cùng với hai người bạn thân là Ronald Weasley và Hermione Granger, Harry phát hiện ra Sirius Black, là một tù nhân trốn chạy từ ngục Azkaban, người được tin rằng là một trong những tay sai của chúa tể Voldemort.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/9/9f/Harry_Potter_v%C3%A0_t%C3%AAn_t%C3%B9_nh%C3%A2n_ng%E1%BB%A5c_Azkaban_b%C3%ACa.jpg",
                     CategoryId = 1
                 },
                 new Product
                 {
                     Id = 4,
                     Title = "Harry Potter và Chiếc cốc lửa",
                     Description = "Harry Potter và chiếc cốc lửa (tiếng Anh: Harry Potter and the Goblet of Fire) là một quyển sách thuộc thể loại giả tưởng kỳ ảo được viết bởi tác giả người Anh J. K. Rowling và đây cũng là phần thứ tư trong bộ tiểu thuyết Harry Potter. Câu chuyện kể về cậu bé Harry Potter, một phù thủy trong năm học thứ tư của mình tại Trường Phù thủy và Pháp sư Hogwarts cùng vời những bí ẩn xung quanh việc thêm tên của Harry vào giải đấu Tam Pháp Thuật, buộc cậu phải nỗ lực hết mình để chiến đấu.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/8/88/Harry_Potter_v%C3%A0_Chi%E1%BA%BFc_c%E1%BB%91c_l%E1%BB%ADa_b%C3%ACa.jpg",
                     CategoryId = 2,
                 },
                  new Product
                  {
                      Id = 5,
                      Title = "Harry Potter và Hội Phượng Hoàng",
                      Description = "Harry Potter và hội Phượng hoàng (tiếng Anh: Harry Potter and the Order of the Phoenix) là quyển thứ 5 trong bộ sách Harry Potter của nhà văn J. K. Rowling. Quyển này được đồng loạt xuất bản vào ngày 21 tháng 6 năm 2003 tại Anh, Hoa Kỳ, Canada, Úc và một vài quốc gia khác. Trong ngày đầu tiên xuất bản, nó đã bán được gần 7 triệu cuốn riêng tại Hoa Kỳ và Anh. Nguyên bản tiếng Anh dài 38 chương và gồm khoảng 255.000 chữ.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/7/74/Harry_Potter_v%C3%A0_H%E1%BB%99i_ph%C6%B0%E1%BB%A3ng_ho%C3%A0ng.jpg",
                      CategoryId = 2,
                      Featured = true
                  },
                  new Product
                  {
                      Id = 6,
                      Title = "Harry Potter và Hoàng tử lai",
                      Description = "Harry Potter và Hoàng tử lai (tiếng Anh: Harry Potter and the Half-Blood Prince) là quyển sách thứ sáu trong bộ sách giả tưởng nổi tiếng Harry Potter của tác giả J.K. Rowling. Cũng như các quyển trước, nó cũng trở thành một trong những best-seller (sách bán chạy nhất) của năm nó xuất bản. Quyển sách này được tung ra bản tiếng Anh cùng lúc trên toàn thế giới vào ngày 16 tháng 7 năm 2005, đặc biệt là ở Anh, Mỹ, Canada và Úc. Chỉ trong 24 giờ đầu tiên, nó đã bán được hơn 6,9 triệu quyển khắp nước Mỹ.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/a/a5/HBP.JPG",
                      CategoryId = 2,
                  },
                  new Product
                  {
                      Id = 7,
                      Title = "Harry Potter và Bảo bối Tử thần",
                      Description = "Harry Potter và Bảo bối Tử thần (nguyên tác tiếng Anh: Harry Potter and the Deathly Hallows) là cuốn sách thứ bảy và cũng là cuối cùng của bộ tiểu thuyết giả tưởng Harry Potter của nhà văn Anh J.K. Rowling.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/4/4d/HARRY-7.jpg",
                      CategoryId = 3,
                  },
                  new Product
                  {
                      Id = 8,
                      Title = "Diablo II",
                      Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                      CategoryId = 3,
                  },
                  new Product
                  {
                      Id = 9,
                      Title = "Day of the Tentacle",
                      Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                      CategoryId = 3,
                  },
                  new Product
                  {
                      Id = 10,
                      Title = "Xbox",
                      Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                      CategoryId = 3,
                      Featured = true
                  },
                  new Product
                  {
                      Id = 11,
                      Title = "Super Nintendo Entertainment System",
                      Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                      CategoryId = 3,
                  }
             );

            modelBuilder.Entity<ProductVariant>().HasData(
               new ProductVariant
               {
                   ProductId = 1,
                   ProductTypeId = 2,
                   Price = 9.99m,
                   OriginalPrice = 19.99m
               },
               new ProductVariant
               {
                   ProductId = 1,
                   ProductTypeId = 3,
                   Price = 7.99m
               },
               new ProductVariant
               {
                   ProductId = 1,
                   ProductTypeId = 4,
                   Price = 19.99m,
                   OriginalPrice = 29.99m
               },
               new ProductVariant
               {
                   ProductId = 2,
                   ProductTypeId = 2,
                   Price = 7.99m,
                   OriginalPrice = 14.99m
               },
               new ProductVariant
               {
                   ProductId = 3,
                   ProductTypeId = 2,
                   Price = 6.99m
               },
               new ProductVariant
               {
                   ProductId = 4,
                   ProductTypeId = 5,
                   Price = 3.99m
               },
               new ProductVariant
               {
                   ProductId = 4,
                   ProductTypeId = 6,
                   Price = 9.99m
               },
               new ProductVariant
               {
                   ProductId = 4,
                   ProductTypeId = 7,
                   Price = 19.99m
               },
               new ProductVariant
               {
                   ProductId = 5,
                   ProductTypeId = 5,
                   Price = 3.99m,
               },
               new ProductVariant
               {
                   ProductId = 6,
                   ProductTypeId = 5,
                   Price = 2.99m
               },
               new ProductVariant
               {
                   ProductId = 7,
                   ProductTypeId = 8,
                   Price = 19.99m,
                   OriginalPrice = 29.99m
               },
               new ProductVariant
               {
                   ProductId = 7,
                   ProductTypeId = 9,
                   Price = 69.99m
               },
               new ProductVariant
               {
                   ProductId = 7,
                   ProductTypeId = 10,
                   Price = 49.99m,
                   OriginalPrice = 59.99m
               },
               new ProductVariant
               {
                   ProductId = 8,
                   ProductTypeId = 8,
                   Price = 9.99m,
                   OriginalPrice = 24.99m,
               },
               new ProductVariant
               {
                   ProductId = 9,
                   ProductTypeId = 8,
                   Price = 14.99m
               },
               new ProductVariant
               {
                   ProductId = 10,
                   ProductTypeId = 1,
                   Price = 159.99m,
                   OriginalPrice = 299m
               },
               new ProductVariant
               {
                   ProductId = 11,
                   ProductTypeId = 1,
                   Price = 79.99m,
                   OriginalPrice = 399m
               }
           );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
