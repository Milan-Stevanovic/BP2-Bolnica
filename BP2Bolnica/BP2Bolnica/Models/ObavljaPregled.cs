using System;
using System.Collections.Generic;

#nullable disable

namespace BP2Bolnica.Models
{
    public partial class ObavljaPregled
    {
        public ObavljaPregled()
        {
            Intervencijas = new HashSet<Intervencija>();
        }

        public int IdZaposlenog { get; set; }
        public int IdP { get; set; }

        public virtual Pregled IdPNavigation { get; set; }
        public virtual Doktor IdZaposlenogNavigation { get; set; }
        public virtual ICollection<Intervencija> Intervencijas { get; set; }
    }
}
