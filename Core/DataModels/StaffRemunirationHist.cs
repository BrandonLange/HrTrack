//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class StaffRemunirationHist
    {
        public int StaffRemunirationHistID { get; set; }
        public int StaffID { get; set; }
        public string PositionName { get; set; }
        public System.DateTime IncreaseDate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Benifits { get; set; }
        public string Notes { get; set; }
    
        public virtual Staff Staff { get; set; }
        public virtual Staff Staff1 { get; set; }
    }
}
