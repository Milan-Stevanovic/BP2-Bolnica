using System;
using System.Collections.Generic;

#nullable disable

namespace BP2Bolnica.Models
{
    public partial class ZdravstveniRadnik
    {
        public int IdZaposlenog { get; set; }
        public int? BrojLicence { get; set; }
        public string TipZdrRad { get; set; }

        public virtual Zaposleni IdZaposlenogNavigation { get; set; }
        public virtual Doktor Doktor { get; set; }
        public virtual MedicinskiTehnicar MedicinskiTehnicar { get; set; }
    }
}
