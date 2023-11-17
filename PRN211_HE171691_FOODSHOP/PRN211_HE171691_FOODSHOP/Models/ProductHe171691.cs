using System;
using System.Collections.Generic;

namespace PRN211_HE171691_FOODSHOP.Models
{
    public partial class ProductHe171691
    {
        public ProductHe171691()
        {
            ImageProductHe171691s = new HashSet<ImageProductHe171691>();
            OrderDetailsHe171691s = new HashSet<OrderDetailsHe171691>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public double? Price { get; set; }
        public int CategoriesCategoriesId { get; set; }
        public string? Description { get; set; }
        public double? StockQuantity { get; set; }

        public virtual CategoriesHe171691 CategoriesCategories { get; set; } = null!;
        public virtual ICollection<ImageProductHe171691> ImageProductHe171691s { get; set; }
        public virtual ICollection<OrderDetailsHe171691> OrderDetailsHe171691s { get; set; }
    }
}
