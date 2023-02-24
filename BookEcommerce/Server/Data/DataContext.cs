namespace BookEcommerce.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Product> Products { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "Harry Potter và Hòn đá Phù thủy",
                     Description = "Harry Potter và Hòn đá Phù thủy (nguyên tác: Harry Potter and the Philosopher's Stone) là tiểu thuyết kỳ ảo của văn sĩ người Anh J. K. Rowling. Đây là cuốn đầu trong loạt tiểu thuyết Harry Potter và là tiểu thuyết đầu tay của J. K. Rowling. Nội dung sách kể về Harry Potter, một phù thủy thiếu niên chỉ biết về tiềm năng phép thuật của mình sau khi nhận thư mời nhập học tại Học viện Ma thuật và Pháp thuật Hogwarts vào đúng vào dịp sinh nhật thứ mười một. Ngay năm học đầu tiên, Harry đã có những người bạn thân lẫn những đối thủ ở trường như Ron, Hermione, Draco,.... Được bạn bè giúp sức, Harry chiến đấu chống lại sự trở lại của Chúa tể Hắc ám Voldemort, kẻ đã sát hại cha mẹ cậu nhưng lại thảm bại khi toan giết Harry dù cậu khi đó chỉ mới 15 tháng tuổi.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/5/51/Harry_Potter_v%C3%A0_H%C3%B2n_%C4%91%C3%A1_ph%C3%B9_th%E1%BB%A7y_b%C3%ACa_2003.jpeg",
                     Price = 9.99m
                 },
             new Product
             {
                 Id = 2,
                 Title = "Harry Potter và Phòng chứa Bí mật",
                 Description = "Harry Potter và Phòng chứa Bí mật (tiếng Anh: Harry Potter and the Chamber of Secrets) là quyển thứ hai trong loạt truyện Harry Potter của J. K. Rowling. Truyện được phát hành bằng tiếng Anh tại Anh, Hoa Kỳ và nhiều nước khác vào ngày 2 tháng 7 năm 1998. Đến tháng 12 năm 2006 riêng tại Mỹ đã có khoảng 14.9 triệu bản được tiêu thụ. Bản dịch tiếng Việt được nhà văn Lý Lan dịch và xuất bản bởi Nhà xuất bản Trẻ thành 8 tập, in thành sách tháng 2 năm 2001.",
                 ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/6/62/Harry_Potter_v%C3%A0_Ph%C3%B2ng_ch%E1%BB%A9a_b%C3%AD_m%E1%BA%ADt.jpg",
                 Price = 8.99m
             },
             new Product
             {
                 Id = 3,
                 Title = "Harry Potter và tên tù nhân ngục Azkaban",
                 Description = "Harry Potter và tên tù nhân ngục Azkaban (tiếng Anh: Harry Potter and the Prisoner of Azkaban) là một quyển tiểu thuyết thuộc thể loại giả tưởng kỳ ảo được viết bởi văn sĩ người Anh J. K. Rowling, đây cũng là tập thứ 3 trong bộ truyện Harry Potter. Quyển sách theo chân Harry Potter, cậu phù thủy nhỏ, trong năm học thứ ba của mình tại Trường Phù thủy và Pháp sư Hogwarts. Cùng với hai người bạn thân là Ronald Weasley và Hermione Granger, Harry phát hiện ra Sirius Black, là một tù nhân trốn chạy từ ngục Azkaban, người được tin rằng là một trong những tay sai của chúa tể Voldemort.",
                 ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/9/9f/Harry_Potter_v%C3%A0_t%C3%AAn_t%C3%B9_nh%C3%A2n_ng%E1%BB%A5c_Azkaban_b%C3%ACa.jpg",
                 Price = 7.99m
             }
             ); 
        }
    }
}
