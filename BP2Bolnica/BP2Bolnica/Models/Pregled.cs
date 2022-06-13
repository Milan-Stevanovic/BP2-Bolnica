using System;
using System.Collections.Generic;

#nullable disable

namespace BP2Bolnica.Models
{
    public partial class Pregled
    {
        public Pregled()
        {
            ObavljaPregleds = new HashSet<ObavljaPregled>();
        }

        public int IdP { get; set; }
        public DateTime DatumP { get; set; }
        public TimeSpan VremeP { get; set; }
        public int BrojZdrKnjiz { get; set; }
        public int IdZaposlenog { get; set; }

        public virtual Pacijent BrojZdrKnjizNavigation { get; set; }
        public virtual MedicinskiTehnicar IdZaposlenogNavigation { get; set; }
        public virtual ICollection<ObavljaPregled> ObavljaPregleds { get; set; }
    }
}
