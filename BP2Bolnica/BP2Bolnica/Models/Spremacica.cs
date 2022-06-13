using System;
using System.Collections.Generic;

#nullable disable

namespace BP2Bolnica.Models
{
    public partial class Spremacica
    {
        public int IdZaposlenog { get; set; }
        public int IdOdeljenja { get; set; }

        public virtual Odeljenje IdOdeljenjaNavigation { get; set; }
        public virtual Zaposleni IdZaposlenogNavigation { get; set; }
    }
}
