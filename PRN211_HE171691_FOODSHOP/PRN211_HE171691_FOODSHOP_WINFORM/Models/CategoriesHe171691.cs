using System;
using System.Collections.Generic;

namespace PRN211_HE171691_FOODSHOP_WINFORM.Models
{
    public partial class CategoriesHe171691
    {
        public CategoriesHe171691()
        {
            ProductHe171691s = new HashSet<ProductHe171691>();
        }

        public int CategoriesId { get; set; }
        public string CategoriesName { get; set; } = null!;

        public virtual ICollection<ProductHe171691> ProductHe171691s { get; set; }
    }
}
