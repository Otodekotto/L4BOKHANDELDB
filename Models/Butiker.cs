using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3DatabaseWinform.Models
{
    public partial class Butiker
    {
        public Butiker()
        {
            LagerSaldos = new HashSet<LagerSaldo>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string ButiksNamn { get; set; }
        public string Adress { get; set; }
        public string Stad { get; set; }

        public virtual ICollection<LagerSaldo> LagerSaldos { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
