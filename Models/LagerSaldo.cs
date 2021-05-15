using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3DatabaseWinform.Models
{
    public partial class LagerSaldo
    {
        public string Isbn13id { get; set; }
        public int ButiksId { get; set; }
        public int Antal { get; set; }

        public virtual Butiker Butiks { get; set; }
        public virtual Böcker Isbn13 { get; set; }
    }
}
