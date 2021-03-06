using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3DatabaseWinform.Models
{
    public partial class Författare
    {
        public Författare()
        {
            Böckers = new HashSet<Böcker>();
        }

        public int Id { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Födelsedatum { get; set; }

        public virtual ICollection<Böcker> Böckers { get; set; }
    }
}
