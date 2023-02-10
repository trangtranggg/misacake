using System;
using System.Collections.Generic;

namespace MisaCake_Store.Model
{
    public partial class Type
    {
        public Type()
        {
            Cakes = new HashSet<Cake>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Cake> Cakes { get; set; }
    }
}
