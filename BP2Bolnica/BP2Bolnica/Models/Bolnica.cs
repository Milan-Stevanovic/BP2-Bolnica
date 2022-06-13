using System;
using System.Collections.Generic;

#nullable disable

namespace BP2Bolnica.Models
{
    public partial class Bolnica
    {
        public Bolnica()
        {
            Zaposlenis = new HashSet<Zaposleni>();
        }

        public int IdBolnice { get; set; }
        public string NazivBolnice { get; set; }

        public virtual ICollection<Zaposleni> Zaposlenis { get; set; }
    }
}
