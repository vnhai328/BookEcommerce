using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 2, "Harry Potter và chiếc cốc lửa (tiếng Anh: Harry Potter and the Goblet of Fire) là một quyển sách thuộc thể loại giả tưởng kỳ ảo được viết bởi tác giả người Anh J. K. Rowling và đây cũng là phần thứ tư trong bộ tiểu thuyết Harry Potter. Câu chuyện kể về cậu bé Harry Potter, một phù thủy trong năm học thứ tư của mình tại Trường Phù thủy và Pháp sư Hogwarts cùng vời những bí ẩn xung quanh việc thêm tên của Harry vào giải đấu Tam Pháp Thuật, buộc cậu phải nỗ lực hết mình để chiến đấu.", "https://upload.wikimedia.org/wikipedia/vi/8/88/Harry_Potter_v%C3%A0_Chi%E1%BA%BFc_c%E1%BB%91c_l%E1%BB%ADa_b%C3%ACa.jpg", 8.99m, "Harry Potter và Chiếc cốc lửa" },
                    { 5, 2, "Harry Potter và hội Phượng hoàng (tiếng Anh: Harry Potter and the Order of the Phoenix) là quyển thứ 5 trong bộ sách Harry Potter của nhà văn J. K. Rowling. Quyển này được đồng loạt xuất bản vào ngày 21 tháng 6 năm 2003 tại Anh, Hoa Kỳ, Canada, Úc và một vài quốc gia khác. Trong ngày đầu tiên xuất bản, nó đã bán được gần 7 triệu cuốn riêng tại Hoa Kỳ và Anh. Nguyên bản tiếng Anh dài 38 chương và gồm khoảng 255.000 chữ.", "https://upload.wikimedia.org/wikipedia/vi/7/74/Harry_Potter_v%C3%A0_H%E1%BB%99i_ph%C6%B0%E1%BB%A3ng_ho%C3%A0ng.jpg", 8.99m, "Harry Potter và Hội Phượng Hoàng" },
                    { 6, 2, "Harry Potter và Hoàng tử lai (tiếng Anh: Harry Potter and the Half-Blood Prince) là quyển sách thứ sáu trong bộ sách giả tưởng nổi tiếng Harry Potter của tác giả J.K. Rowling. Cũng như các quyển trước, nó cũng trở thành một trong những best-seller (sách bán chạy nhất) của năm nó xuất bản. Quyển sách này được tung ra bản tiếng Anh cùng lúc trên toàn thế giới vào ngày 16 tháng 7 năm 2005, đặc biệt là ở Anh, Mỹ, Canada và Úc. Chỉ trong 24 giờ đầu tiên, nó đã bán được hơn 6,9 triệu quyển khắp nước Mỹ.", "https://upload.wikimedia.org/wikipedia/vi/a/a5/HBP.JPG", 8.99m, "Harry Potter và Hoàng tử lai" },
                    { 7, 3, "Harry Potter và Bảo bối Tử thần (nguyên tác tiếng Anh: Harry Potter and the Deathly Hallows) là cuốn sách thứ bảy và cũng là cuối cùng của bộ tiểu thuyết giả tưởng Harry Potter của nhà văn Anh J.K. Rowling.", "https://upload.wikimedia.org/wikipedia/vi/4/4d/HARRY-7.jpg", 8.99m, "Harry Potter và Bảo bối Tử thần" },
                    { 8, 3, "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", 8.99m, "Diablo II" },
                    { 9, 3, "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", 8.99m, "Day of the Tentacle" },
                    { 10, 3, "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", 8.99m, "Xbox" },
                    { 11, 3, "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", 8.99m, "Super Nintendo Entertainment System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
