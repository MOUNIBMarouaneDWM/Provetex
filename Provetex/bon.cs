//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Provetex
{
    using System;
    using System.Collections.Generic;
    
    public partial class bon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bon()
        {
            this.chiques = new HashSet<chique>();
        }
    
        public int C_serie_bon { get; set; }
        public Nullable<int> C_purchase { get; set; }
        public Nullable<int> C_numero_bon { get; set; }
        public string C_payement_type { get; set; }
        public Nullable<decimal> C_prix_bon { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual purchase purchase { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chique> chiques { get; set; }
    }
}
