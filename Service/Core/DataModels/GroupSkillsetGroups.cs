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
    
    public partial class GroupSkillsetGroups
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GroupSkillsetGroups()
        {
            this.GroupSkillset = new HashSet<GroupSkillset>();
        }
    
        public int SkillsetGroupID { get; set; }
        public int CompanyGroupID { get; set; }
        public string GroupDesc { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> MeasureType { get; set; }
        public Nullable<int> Rank { get; set; }
    
        public virtual CompanyGroup CompanyGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroupSkillset> GroupSkillset { get; set; }
    }
}
