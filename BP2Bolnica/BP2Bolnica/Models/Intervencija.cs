using System;
using System.Collections.Generic;

#nullable disable

namespace BP2Bolnica.Models
{
    public partial class Intervencija
    {
        public int IdI { get; set; }
        public DateTime DatumI { get; set; }
        public TimeSpan VremeI { get; set; }
        public int? TrajanjeI { get; set; }
        public int IdZaposlenog { get; set; }
        public int IdP { get; set; }
        public int RbSale { get; set; }
        public int IdOdeljenja { get; set; }

        public virtual ObavljaPregled Id { get; set; }
        public virtual OperacionaSala OperacionaSala { get; set; }
    }
}
