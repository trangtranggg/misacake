using System;
using System.Collections.Generic;

namespace MisaCake_Store.Model
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public int CakeId { get; set; }
        public int Quantity { get; set; }

        public virtual Cake Cake { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
