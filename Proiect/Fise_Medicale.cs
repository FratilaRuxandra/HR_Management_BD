//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proiect
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fise_Medicale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fise_Medicale()
        {
            this.Angajati = new HashSet<Angajati>();
        }
    
        public int Id_FisaMed { get; set; }
        public string Grupa_Sange { get; set; }
        public Nullable<double> Inaltime { get; set; }
        public Nullable<int> Greutate { get; set; }
        public string Stare_Sanatate { get; set; }
        public string Observatii { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Angajati> Angajati { get; set; }
    }
}
