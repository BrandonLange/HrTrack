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
    
    public partial class LeaveType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LeaveType()
        {
            this.Leave = new HashSet<Leave>();
        }
    
        public int LeaveTypeID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> PayPerc { get; set; }
        public Nullable<int> EarnType { get; set; }
        public Nullable<decimal> EarnDays { get; set; }
        public Nullable<int> MustApplyWorkingDaysBefore { get; set; }
        public Nullable<bool> CarryOver { get; set; }
        public Nullable<decimal> CarryOverCap { get; set; }
        public Nullable<int> CompanyPoliciesID { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Company Company1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leave> Leave { get; set; }
    }
}
