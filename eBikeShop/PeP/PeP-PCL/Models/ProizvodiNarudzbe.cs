using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeP_PCL.Models
{
    public class ProizvodiNarudzbe
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int ProizvodID { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string Sifra { get; set; }
        public Nullable<decimal> ProsjecnaOcjena { get; set; }
        public int Kolicina { get; set; }
        public Nullable<decimal> Iznos { get; set; }
    }
}
