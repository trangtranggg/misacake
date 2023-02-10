using System;
using System.Collections.Generic;

namespace MisaCake_Store.Model
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public int OrderStatus { get; set; }
        public int AccountId { get; set; }

        public virtual UserAccount Account { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
