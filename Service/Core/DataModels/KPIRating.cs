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
    
    public partial class KPIRating
    {
        public int KPIRatingID { get; set; }
        public Nullable<int> KPIRaterID { get; set; }
        public Nullable<int> KPIQuestionnaireID { get; set; }
        public Nullable<int> OptionNo { get; set; }
        public Nullable<int> OptionWeight { get; set; }
        public Nullable<decimal> AdjWeight { get; set; }
    }
}