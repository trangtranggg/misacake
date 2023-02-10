using System;
using System.Collections.Generic;

namespace MisaCake_Store.Model
{
    public partial class Brand
    {
        public Brand()
        {
            Cakes = new HashSet<Cake>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }

        public virtual ICollection<Cake> Cakes { get; set; }
    }
}
