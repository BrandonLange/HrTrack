using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.HrTrackServiceModels
{
    [DataContract]
    public class RequestBase
    {
        [DataMember(Order = 0)]
        public ActionType Action { get; set; }
        [DataMember(Order = 1)]
        public string CustomField { get; set; }
        [DataMember(Order = 2)]
        public string CustomValue { get; set; }
    }

    [DataContract]
    public class ResponseBase
    {
        public ResponseBase()
        {
            this.Success = true;
            this.ErrorHint = String.Empty;
            this.TechnicalError = String.Empty;
        }

        [DataMember(Order = 0)]
        public bool Success { get; set; }
        [DataMember(Order = 1)]
        public string ErrorHint { get; set; }
        [DataMember(Order = 2)]
        public string TechnicalError { get; set; }
    }

    [DataContract]
    public enum ActionType
    {
        [EnumMember]
        GetAll = 0,
        [EnumMember]
        Get = 1,
        [EnumMember]
        Create = 2,
        [EnumMember]
        Modify = 3,
        [EnumMember]
        Delete = 4,
    }
}
