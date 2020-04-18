using System;
using System.Collections.Generic;

namespace Day1_Assignment.Models
{
    public partial class Users
    {
        public Users()
        {
            RefreshToken = new HashSet<RefreshToken>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }
        public string Token { get; set; }

        public virtual Roles Role { get; set; }
        public virtual ICollection<RefreshToken> RefreshToken { get; set; }
    }
}
