//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PeP_API.Models
{
    using System;
    
    public partial class ProizvodiStavke_Result
    {
        public int ProizvodID { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public int Kolicina { get; set; }
        public Nullable<decimal> Iznos { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
    }
}
