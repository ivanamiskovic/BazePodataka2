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
    
    public partial class penzionerSet
    {
        public decimal osigur { get; set; }
        public decimal sfr { get; set; }
        public decimal brckar { get; set; }
        public decimal clan_kluba_sfr { get; set; }
        public decimal clan_kluba_posetilac_brckar_clan_kluba { get; set; }
    
        public virtual clan_klubaSet clan_klubaSet { get; set; }
    }
}
