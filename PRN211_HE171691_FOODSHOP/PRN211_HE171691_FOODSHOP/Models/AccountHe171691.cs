using System;
using System.Collections.Generic;

namespace PRN211_HE171691_FOODSHOP.Models
{
    public partial class AccountHe171691
    {
        public AccountHe171691()
        {
            OrdersHe171691s = new HashSet<OrdersHe171691>();
        }

        public int AccId { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? UserName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }

        public virtual ICollection<OrdersHe171691> OrdersHe171691s { get; set; }
    }
}
