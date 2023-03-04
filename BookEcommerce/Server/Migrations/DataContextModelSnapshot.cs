﻿// <auto-generated />
using System;
using BookEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookEcommerce.Shared.CartItem", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId", "ProductTypeId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("BookEcommerce.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Stories",
                            Url = "stories"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dramma",
                            Url = "dramma"
                        });
                });

            modelBuilder.Entity("BookEcommerce.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookEcommerce.Shared.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ProductId", "ProductTypeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("BookEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Harry Potter và Hòn đá Phù thủy (nguyên tác: Harry Potter and the Philosopher's Stone) là tiểu thuyết kỳ ảo của văn sĩ người Anh J. K. Rowling. Đây là cuốn đầu trong loạt tiểu thuyết Harry Potter và là tiểu thuyết đầu tay của J. K. Rowling. Nội dung sách kể về Harry Potter, một phù thủy thiếu niên chỉ biết về tiềm năng phép thuật của mình sau khi nhận thư mời nhập học tại Học viện Ma thuật và Pháp thuật Hogwarts vào đúng vào dịp sinh nhật thứ mười một. Ngay năm học đầu tiên, Harry đã có những người bạn thân lẫn những đối thủ ở trường như Ron, Hermione, Draco,.... Được bạn bè giúp sức, Harry chiến đấu chống lại sự trở lại của Chúa tể Hắc ám Voldemort, kẻ đã sát hại cha mẹ cậu nhưng lại thảm bại khi toan giết Harry dù cậu khi đó chỉ mới 15 tháng tuổi.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/5/51/Harry_Potter_v%C3%A0_H%C3%B2n_%C4%91%C3%A1_ph%C3%B9_th%E1%BB%A7y_b%C3%ACa_2003.jpeg",
                            Title = "Harry Potter và Hòn đá Phù thủy"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Harry Potter và Phòng chứa Bí mật (tiếng Anh: Harry Potter and the Chamber of Secrets) là quyển thứ hai trong loạt truyện Harry Potter của J. K. Rowling. Truyện được phát hành bằng tiếng Anh tại Anh, Hoa Kỳ và nhiều nước khác vào ngày 2 tháng 7 năm 1998. Đến tháng 12 năm 2006 riêng tại Mỹ đã có khoảng 14.9 triệu bản được tiêu thụ. Bản dịch tiếng Việt được nhà văn Lý Lan dịch và xuất bản bởi Nhà xuất bản Trẻ thành 8 tập, in thành sách tháng 2 năm 2001.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/6/62/Harry_Potter_v%C3%A0_Ph%C3%B2ng_ch%E1%BB%A9a_b%C3%AD_m%E1%BA%ADt.jpg",
                            Title = "Harry Potter và Phòng chứa Bí mật"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Harry Potter và tên tù nhân ngục Azkaban (tiếng Anh: Harry Potter and the Prisoner of Azkaban) là một quyển tiểu thuyết thuộc thể loại giả tưởng kỳ ảo được viết bởi văn sĩ người Anh J. K. Rowling, đây cũng là tập thứ 3 trong bộ truyện Harry Potter. Quyển sách theo chân Harry Potter, cậu phù thủy nhỏ, trong năm học thứ ba của mình tại Trường Phù thủy và Pháp sư Hogwarts. Cùng với hai người bạn thân là Ronald Weasley và Hermione Granger, Harry phát hiện ra Sirius Black, là một tù nhân trốn chạy từ ngục Azkaban, người được tin rằng là một trong những tay sai của chúa tể Voldemort.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/9/9f/Harry_Potter_v%C3%A0_t%C3%AAn_t%C3%B9_nh%C3%A2n_ng%E1%BB%A5c_Azkaban_b%C3%ACa.jpg",
                            Title = "Harry Potter và tên tù nhân ngục Azkaban"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Harry Potter và chiếc cốc lửa (tiếng Anh: Harry Potter and the Goblet of Fire) là một quyển sách thuộc thể loại giả tưởng kỳ ảo được viết bởi tác giả người Anh J. K. Rowling và đây cũng là phần thứ tư trong bộ tiểu thuyết Harry Potter. Câu chuyện kể về cậu bé Harry Potter, một phù thủy trong năm học thứ tư của mình tại Trường Phù thủy và Pháp sư Hogwarts cùng vời những bí ẩn xung quanh việc thêm tên của Harry vào giải đấu Tam Pháp Thuật, buộc cậu phải nỗ lực hết mình để chiến đấu.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/8/88/Harry_Potter_v%C3%A0_Chi%E1%BA%BFc_c%E1%BB%91c_l%E1%BB%ADa_b%C3%ACa.jpg",
                            Title = "Harry Potter và Chiếc cốc lửa"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Harry Potter và hội Phượng hoàng (tiếng Anh: Harry Potter and the Order of the Phoenix) là quyển thứ 5 trong bộ sách Harry Potter của nhà văn J. K. Rowling. Quyển này được đồng loạt xuất bản vào ngày 21 tháng 6 năm 2003 tại Anh, Hoa Kỳ, Canada, Úc và một vài quốc gia khác. Trong ngày đầu tiên xuất bản, nó đã bán được gần 7 triệu cuốn riêng tại Hoa Kỳ và Anh. Nguyên bản tiếng Anh dài 38 chương và gồm khoảng 255.000 chữ.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/7/74/Harry_Potter_v%C3%A0_H%E1%BB%99i_ph%C6%B0%E1%BB%A3ng_ho%C3%A0ng.jpg",
                            Title = "Harry Potter và Hội Phượng Hoàng"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Harry Potter và Hoàng tử lai (tiếng Anh: Harry Potter and the Half-Blood Prince) là quyển sách thứ sáu trong bộ sách giả tưởng nổi tiếng Harry Potter của tác giả J.K. Rowling. Cũng như các quyển trước, nó cũng trở thành một trong những best-seller (sách bán chạy nhất) của năm nó xuất bản. Quyển sách này được tung ra bản tiếng Anh cùng lúc trên toàn thế giới vào ngày 16 tháng 7 năm 2005, đặc biệt là ở Anh, Mỹ, Canada và Úc. Chỉ trong 24 giờ đầu tiên, nó đã bán được hơn 6,9 triệu quyển khắp nước Mỹ.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/a/a5/HBP.JPG",
                            Title = "Harry Potter và Hoàng tử lai"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Harry Potter và Bảo bối Tử thần (nguyên tác tiếng Anh: Harry Potter and the Deathly Hallows) là cuốn sách thứ bảy và cũng là cuối cùng của bộ tiểu thuyết giả tưởng Harry Potter của nhà văn Anh J.K. Rowling.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/4/4d/HARRY-7.jpg",
                            Title = "Harry Potter và Bảo bối Tử thần"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                            Title = "Diablo II"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                            Title = "Day of the Tentacle"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                            Title = "Xbox"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                            Title = "Super Nintendo Entertainment System"
                        });
                });

            modelBuilder.Entity("BookEcommerce.Shared.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Paperback"
                        },
                        new
                        {
                            Id = 3,
                            Name = "E-Book"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Audiobook"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Stream"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Blu-ray"
                        },
                        new
                        {
                            Id = 7,
                            Name = "VHS"
                        },
                        new
                        {
                            Id = 8,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 9,
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Xbox"
                        });
                });

            modelBuilder.Entity("BookEcommerce.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 2,
                            OriginalPrice = 19.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 3,
                            OriginalPrice = 0m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 4,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 2,
                            OriginalPrice = 14.99m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 2,
                            OriginalPrice = 0m,
                            Price = 6.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 5,
                            OriginalPrice = 0m,
                            Price = 3.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 6,
                            OriginalPrice = 0m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 7,
                            OriginalPrice = 0m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 5,
                            OriginalPrice = 0m,
                            Price = 3.99m
                        },
                        new
                        {
                            ProductId = 6,
                            ProductTypeId = 5,
                            OriginalPrice = 0m,
                            Price = 2.99m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 8,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 9,
                            OriginalPrice = 0m,
                            Price = 69.99m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 10,
                            OriginalPrice = 59.99m,
                            Price = 49.99m
                        },
                        new
                        {
                            ProductId = 8,
                            ProductTypeId = 8,
                            OriginalPrice = 24.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 9,
                            ProductTypeId = 8,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 10,
                            ProductTypeId = 1,
                            OriginalPrice = 299m,
                            Price = 159.99m
                        },
                        new
                        {
                            ProductId = 11,
                            ProductTypeId = 1,
                            OriginalPrice = 399m,
                            Price = 79.99m
                        });
                });

            modelBuilder.Entity("BookEcommerce.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PaswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PaswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookEcommerce.Shared.OrderItem", b =>
                {
                    b.HasOne("BookEcommerce.Shared.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookEcommerce.Shared.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookEcommerce.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("BookEcommerce.Shared.Product", b =>
                {
                    b.HasOne("BookEcommerce.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookEcommerce.Shared.ProductVariant", b =>
                {
                    b.HasOne("BookEcommerce.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookEcommerce.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("BookEcommerce.Shared.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("BookEcommerce.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
