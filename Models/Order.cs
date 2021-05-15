using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3DatabaseWinform.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? KundId { get; set; }
        public int? ButikId { get; set; }

        public virtual Butiker Butik { get; set; }
        public virtual Kunder Kund { get; set; }
    }
}
