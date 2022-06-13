using System;
using System.Collections.Generic;

#nullable disable

namespace BP2Bolnica.Models
{
    public partial class Zaposleni
    {
        public int IdZaposlenog { get; set; }
        public string JmbgZ { get; set; }
        public string ImeZ { get; set; }
        public string PrezimeZ { get; set; }
        public int? PlataZ { get; set; }
        public string TipZaposlenog { get; set; }
        public int IdBolnice { get; set; }

        public virtual Bolnica IdBolniceNavigation { get; set; }
        public virtual Obezbedjenje Obezbedjenje { get; set; }
        public virtual Spremacica Spremacica { get; set; }
        public virtual ZdravstveniRadnik ZdravstveniRadnik { get; set; }
    }
}
