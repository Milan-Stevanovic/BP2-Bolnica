using System;
using System.Collections.Generic;

#nullable disable

namespace BP2Bolnica.Models
{
    public partial class OperacionaSala
    {
        public OperacionaSala()
        {
            Intervencijas = new HashSet<Intervencija>();
        }

        public int RbSale { get; set; }
        public string NazivSale { get; set; }
        public bool? ImaXray { get; set; }
        public int? Sprat { get; set; }
        public int IdOdeljenja { get; set; }

        public virtual Odeljenje IdOdeljenjaNavigation { get; set; }
        public virtual ICollection<Intervencija> Intervencijas { get; set; }
    }
}
