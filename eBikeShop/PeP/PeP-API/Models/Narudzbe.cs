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
    using System.Collections.Generic;
    
    public partial class Narudzbe
    {
        public Narudzbe()
        {
            this.Izlazis = new HashSet<Izlazi>();
            this.NarudzbaStavkes = new HashSet<NarudzbaStavke>();
        }
    
        public int NarudzbaID { get; set; }
        public string BrojNarudzbe { get; set; }
        public int KupacID { get; set; }
        public System.DateTime Datum { get; set; }
        public bool Status { get; set; }
        public Nullable<bool> Otkazano { get; set; }
    
        public virtual ICollection<Izlazi> Izlazis { get; set; }
        public virtual Kupci Kupci { get; set; }
        public virtual ICollection<NarudzbaStavke> NarudzbaStavkes { get; set; }
    }
}
