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
    
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            this.BankCards = new HashSet<BankCards>();
            this.Claims = new HashSet<Claims>();
            this.Leave = new HashSet<Leave>();
            this.Licences = new HashSet<Licences>();
            this.OverTime = new HashSet<OverTime>();
            this.SerialLicence = new HashSet<SerialLicence>();
            this.SkillsMatrix = new HashSet<SkillsMatrix>();
            this.StaffLanguage = new HashSet<StaffLanguage>();
            this.StaffPositionHist = new HashSet<StaffPositionHist>();
            this.StaffPositionHist1 = new HashSet<StaffPositionHist>();
            this.StaffRemunirationHist = new HashSet<StaffRemunirationHist>();
            this.StaffRemunirationHist1 = new HashSet<StaffRemunirationHist>();
            this.TeamMembers = new HashSet<TeamMembers>();
            this.TravelLog = new HashSet<TravelLog>();
            this.Visas = new HashSet<Visas>();
        }
    
        public int StaffID { get; set; }
        public int CompanyID { get; set; }
        public string EmployeeRefNo { get; set; }
        public Nullable<int> SystemUserID { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string KnownAs { get; set; }
        public Nullable<int> PictureDocID { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string NationalityISO { get; set; }
        public string IDNumber { get; set; }
        public Nullable<int> IDDoc { get; set; }
        public string PassportNo1 { get; set; }
        public Nullable<int> PassportDoc1 { get; set; }
        public string PassportNo2 { get; set; }
        public Nullable<int> PassportDoc2 { get; set; }
        public Nullable<System.DateTime> EmploymentStart { get; set; }
        public Nullable<int> EmploymentTypeID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> EmpContractDocID { get; set; }
        public Nullable<int> EmploymentEnd { get; set; }
        public string HomeAddress1 { get; set; }
        public string HomeAddress2 { get; set; }
        public string HomeAddress3 { get; set; }
        public string HomeAddress4 { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalAddress3 { get; set; }
        public string PostalAddress4 { get; set; }
        public string WorkEmail1 { get; set; }
        public string WorkEmail2 { get; set; }
        public string WorkEmail3 { get; set; }
        public string PrivateEmail { get; set; }
        public string PhoneExtension { get; set; }
        public string PrivateMobileNumber { get; set; }
        public string ContactMobileNumber { get; set; }
        public string HomeNumber { get; set; }
        public string EmergencyContact1 { get; set; }
        public Nullable<int> ECRelation1 { get; set; }
        public string ECContactNumbers1 { get; set; }
        public string EmergencyContact2 { get; set; }
        public Nullable<int> ECRelation2 { get; set; }
        public string ECContactNumbers2 { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public string AccountType { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public Nullable<decimal> LeaveOpeningBal { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<int> LastUpdateID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankCards> BankCards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claims> Claims { get; set; }
        public virtual EmploymentType EmploymentType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leave> Leave { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Licences> Licences { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OverTime> OverTime { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SerialLicence> SerialLicence { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkillsMatrix> SkillsMatrix { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffLanguage> StaffLanguage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffPositionHist> StaffPositionHist { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffPositionHist> StaffPositionHist1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffRemunirationHist> StaffRemunirationHist { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffRemunirationHist> StaffRemunirationHist1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamMembers> TeamMembers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TravelLog> TravelLog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visas> Visas { get; set; }
    }
}