using System;
using System.Collections.Generic;

#nullable disable

namespace BP2Bolnica.Models
{
    public partial class Odeljenje
    {
        public Odeljenje()
        {
            OperacionaSalas = new HashSet<OperacionaSala>();
            Spremacicas = new HashSet<Spremacica>();
        }

        public int IdOdeljenja { get; set; }
        public string NazivOdeljenja { get; set; }
        public int? Sprat { get; set; }

        public virtual ICollection<OperacionaSala> OperacionaSalas { get; set; }
        public virtual ICollection<Spremacica> Spremacicas { get; set; }
    }
}
