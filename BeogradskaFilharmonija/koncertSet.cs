//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeogradskaFilharmonija
{
    using System;
    using System.Collections.Generic;
    
    public partial class koncertSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public koncertSet()
        {
            this.izvodjenjeSet = new HashSet<izvodjenjeSet>();
            this.orkestarSet = new HashSet<orkestarSet>();
            this.sef_dirigentSet = new HashSet<sef_dirigentSet>();
        }
    
        public decimal idkon { get; set; }
        public string nazkon { get; set; }
        public string znrmuzik { get; set; }
        public decimal traj { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<izvodjenjeSet> izvodjenjeSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orkestarSet> orkestarSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sef_dirigentSet> sef_dirigentSet { get; set; }
    }
}
