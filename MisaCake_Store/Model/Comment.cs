using System;
using System.Collections.Generic;

namespace MisaCake_Store.Model
{
    public partial class Comment
    {
        public int AccountId { get; set; }
        public int CakeId { get; set; }
        public short Rate { get; set; }
        public string? Content { get; set; }

        public virtual UserAccount Account { get; set; } = null!;
        public virtual Cake Cake { get; set; } = null!;
    }
}
