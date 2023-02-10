using System;
using System.Collections.Generic;

namespace MisaCake_Store.Model
{
    public partial class UserAccount
    {
        public UserAccount()
        {
            Comments = new HashSet<Comment>();
            Orders = new HashSet<Order>();
        }

        public int AccountId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int? Gender { get; set; }
        public int Role { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
