using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeP_PCL.Models
{
    using System;
    using System.Collections.Generic;

    public class Ocjene
    {
        public int OcjenaID { get; set; }
        public int ProizvodID { get; set; }
        public int KupacID { get; set; }
        public System.DateTime Datum { get; set; }
        public int Ocjena { get; set; }

        public virtual Kupci Kupci { get; set; }
        public virtual Proizvodi Proizvodi { get; set; }
    }
}
