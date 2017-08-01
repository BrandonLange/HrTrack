using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace HrTrackServiceContracts.HrTrackService
{
    [ServiceContract(Name = "HrTrackService")]
    public interface IHrTrackServicee
    {
        #region Test Connection

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "TestConnection", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void TestConnection();

        #endregion Test Connection

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "CompanyGroup/ProcessCompanyGroup?format={format}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Xml)]
        DataModels.HrTrackServiceModels.CompanyGroupResponse ProcessCompanyGroup(string format, DataModels.HrTrackServiceModels.CompanyGroupRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "GroupPolicy/ProcessGroupPolicy?format={format}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Xml)]
        DataModels.HrTrackServiceModels.GroupPolicyResponse ProcessGroupPolicy(string format, DataModels.HrTrackServiceModels.GroupPolicyRequest request);
    }
}
