using System;
using System.Collections.Generic;

#nullable disable

namespace BP2Bolnica.Models
{
    public partial class Doktor
    {
        public Doktor()
        {
            ObavljaPregleds = new HashSet<ObavljaPregled>();
        }

        public int IdZaposlenog { get; set; }
        public string Specijalizacija { get; set; }

        public virtual ZdravstveniRadnik IdZaposlenogNavigation { get; set; }
        public virtual ICollection<ObavljaPregled> ObavljaPregleds { get; set; }
    }
}
