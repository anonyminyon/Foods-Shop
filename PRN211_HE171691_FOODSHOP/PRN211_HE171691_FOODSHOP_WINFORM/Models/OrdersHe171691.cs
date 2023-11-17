using System;
using System.Collections.Generic;

namespace PRN211_HE171691_FOODSHOP_WINFORM.Models
{
    public partial class OrdersHe171691
    {
        public OrdersHe171691()
        {
            OrderDetailsHe171691s = new HashSet<OrderDetailsHe171691>();
        }

        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? TotalAmount { get; set; }
        public int AccountAccId { get; set; }

        public virtual AccountHe171691 AccountAcc { get; set; } = null!;
        public virtual ICollection<OrderDetailsHe171691> OrderDetailsHe171691s { get; set; }
    }
}
