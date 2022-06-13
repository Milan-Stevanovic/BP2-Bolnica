using System;
using System.Collections.Generic;

#nullable disable

namespace BP2Bolnica.Models
{
    public partial class Pacijent
    {
        public Pacijent()
        {
            Pregleds = new HashSet<Pregled>();
        }

        public int BrojZdrKnjiz { get; set; }
        public string JmbgP { get; set; }
        public string ImeP { get; set; }
        public string PrezimeP { get; set; }

        public virtual ICollection<Pregled> Pregleds { get; set; }
    }
}
