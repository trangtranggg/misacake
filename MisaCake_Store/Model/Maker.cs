using System;
using System.Collections.Generic;

namespace MisaCake_Store.Model
{
    public partial class Maker
    {
        public Maker()
        {
            Cakes = new HashSet<Cake>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public decimal? YearBirth { get; set; }

        public virtual ICollection<Cake> Cakes { get; set; }
    }
}
