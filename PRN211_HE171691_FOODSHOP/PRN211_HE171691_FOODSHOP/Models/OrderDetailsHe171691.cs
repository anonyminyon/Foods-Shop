using System;
using System.Collections.Generic;

namespace PRN211_HE171691_FOODSHOP.Models
{
    public partial class OrderDetailsHe171691
    {
        public int OrderdetailId { get; set; }
        public double? Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public double? SubTotal { get; set; }
        public int OrdersOrderId { get; set; }
        public int ProductProductId { get; set; }

        public virtual OrdersHe171691 OrdersOrder { get; set; } = null!;
        public virtual ProductHe171691 ProductProduct { get; set; } = null!;
    }
}
