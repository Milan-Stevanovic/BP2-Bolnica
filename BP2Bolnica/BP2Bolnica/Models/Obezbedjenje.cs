using System;
using System.Collections.Generic;

#nullable disable

namespace BP2Bolnica.Models
{
    public partial class Obezbedjenje
    {
        public int IdZaposlenog { get; set; }
        public bool? DozvolaZaOruzje { get; set; }

        public virtual Zaposleni IdZaposlenogNavigation { get; set; }
    }
}
