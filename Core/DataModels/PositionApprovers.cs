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
    
    public partial class PositionApprovers
    {
        public int PositionApproversID { get; set; }
        public Nullable<int> PositionID { get; set; }
        public Nullable<int> ItemType { get; set; }
        public Nullable<int> ItemLevel { get; set; }
        public Nullable<int> L1ApproverPos1 { get; set; }
        public Nullable<int> L1ApproverPos2 { get; set; }
        public Nullable<int> L1ApproverPos3 { get; set; }
        public Nullable<int> L1ApproverPos4 { get; set; }
        public Nullable<int> L1ApproverPos5 { get; set; }
        public Nullable<int> L2ApproverPos1 { get; set; }
        public Nullable<int> L2ApproverPos2 { get; set; }
        public Nullable<int> L2ApproverPos3 { get; set; }
        public Nullable<int> L2ApproverPos4 { get; set; }
        public Nullable<int> L2ApproverPos5 { get; set; }
    
        public virtual Position Position { get; set; }
    }
}