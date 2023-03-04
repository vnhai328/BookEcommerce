using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEcommerce.Shared
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public byte[] PaswordHash { get; set; }
        public byte[] PaswordSalt { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
