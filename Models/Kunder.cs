using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3DatabaseWinform.Models
{
    public partial class Kunder
    {
        public Kunder()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Personnr { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
