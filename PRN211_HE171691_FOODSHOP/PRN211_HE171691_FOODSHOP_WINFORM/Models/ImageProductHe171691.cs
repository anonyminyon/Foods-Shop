using System;
using System.Collections.Generic;

namespace PRN211_HE171691_FOODSHOP_WINFORM.Models
{
    public partial class ImageProductHe171691
    {
        public int ImageId { get; set; }
        public int ProductProductId { get; set; }
        public int ImagePath { get; set; }

        public virtual ProductHe171691 ProductProduct { get; set; } = null!;
    }
}
