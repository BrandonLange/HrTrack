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
    
    public partial class KPIQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KPIQuestion()
        {
            this.KPIQuestionGroupLink = new HashSet<KPIQuestionGroupLink>();
        }
    
        public int KPIQuestionID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<int> KPIQuestionGroupID { get; set; }
        public Nullable<int> KPIType { get; set; }
        public string KPIHeading { get; set; }
        public string KPIDescription { get; set; }
        public Nullable<int> MeasureType { get; set; }
        public string Option1Description { get; set; }
        public Nullable<int> Option1Weight { get; set; }
        public string Option2Description { get; set; }
        public Nullable<int> Option2Weight { get; set; }
        public string Option3Description { get; set; }
        public Nullable<int> Option3Weight { get; set; }
        public string Option4Description { get; set; }
        public Nullable<int> Option4Weight { get; set; }
        public string Option5Description { get; set; }
        public Nullable<int> Option5Weight { get; set; }
        public Nullable<int> Rank { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KPIQuestionGroupLink> KPIQuestionGroupLink { get; set; }
    }
}
