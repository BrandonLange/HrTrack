using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.HrTrackServiceModels
{
    [DataContract]
    public class CompanyGroupItem
    {
        [DataMember]
        public int CompanyGroupID { get; set; }
        [DataMember]
        public System.Guid GroupGUID { get; set; }
        [DataMember]
        public string GroupName { get; set; }
        [DataMember]
        public byte[] Logo { get; set; }
    }

    [DataContract]
    public class CompanyGroupResponse : ResponseBase
    {
        [DataMember(Order = 0)]
        public List<CompanyGroupItem> CompanyGroupItemList { get; set; }
    }

    [DataContract]
    public class CompanyGroupRequest : RequestBase
    {
        [DataMember(Order = 0)]
        public CompanyGroupItem CompanyGroupItem { get; set; }
    }
}
