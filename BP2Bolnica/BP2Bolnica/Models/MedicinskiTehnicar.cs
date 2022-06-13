using System;
using System.Collections.Generic;

#nullable disable

namespace BP2Bolnica.Models
{
    public partial class MedicinskiTehnicar
    {
        public MedicinskiTehnicar()
        {
            Pregleds = new HashSet<Pregled>();
        }

        public int IdZaposlenog { get; set; }

        public virtual ZdravstveniRadnik IdZaposlenogNavigation { get; set; }
        public virtual ICollection<Pregled> Pregleds { get; set; }
    }
}
