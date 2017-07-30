using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.HrTrackServiceModels
{
    [DataContract]
    public class GroupPoliciesItem
    {
        [DataMember]
        public int GroupPolicyID { get; set; }
        [DataMember]
        public int CompanyGroupID { get; set; }
        [DataMember]
        public Nullable<int> ParentID { get; set; }
        [DataMember]
        public Nullable<int> PolicyLevel { get; set; }
        [DataMember]
        public int Rank { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Policy { get; set; }
        [DataMember]
        public string DocumentRef { get; set; }
        [DataMember]
        public Nullable<int> DocumentID { get; set; }
        [DataMember]
        public Nullable<System.DateTime> LastUpdated { get; set; }
        [DataMember]
        public Nullable<int> LastUpdatedBy { get; set; }
        [DataMember]
        public Nullable<bool> Deleted { get; set; }
    }

    [DataContract]
    public class GroupPolicyResponse : ResponseBase
    {
        [DataMember(Order = 0)]
        public List<GroupPoliciesItem> GroupPolicyItemList { get; set; }
    }

    [DataContract]
    public class GroupPolicyRequest : RequestBase
    {
        [DataMember(Order = 0)]
        public GroupPoliciesItem GroupPoliciesItem { get; set; }
    }
}
