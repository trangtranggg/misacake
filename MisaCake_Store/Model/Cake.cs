using System;
using System.Collections.Generic;

namespace MisaCake_Store.Model
{
    public partial class Cake
    {
        public Cake()
        {
            Comments = new HashSet<Comment>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int CakeId { get; set; }
        public string Name { get; set; } = null!;
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int TypeId { get; set; }
        public int BrandId { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; }
        public int? Status { get; set; }
        public string? Img { get; set; }
        public int? MakerId { get; set; }

        public virtual Brand Brand { get; set; } = null!;
        public virtual Maker? Maker { get; set; }
        public virtual Type Type { get; set; } = null!;
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
