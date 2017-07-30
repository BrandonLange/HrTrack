using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using DataModels.HrTrackServiceModels;
using DBT = DataModels.Transactions;
using AutoMapper;

namespace HrTrackService.HrTrackService
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, UseSynchronizationContext = false)]
    public class HrTrackService : HrTrackServiceContracts.HrTrackService.IHrTrackServicee
    {
        #region Test Connection

        public void TestConnection()
        {

        }

        #endregion Test Connection

        public CompanyGroupResponse ProcessCompanyGroup(string format, CompanyGroupRequest request)
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "JSON";
            }

            switch (format.ToUpper())
            {
                case "XML":
                    {
                        WebOperationContext.Current.OutgoingResponse.Format = WebMessageFormat.Xml;
                    }
                    break;
                case "JSON":
                    {
                        WebOperationContext.Current.OutgoingResponse.Format = WebMessageFormat.Json;
                    }
                    break;
            }

            CompanyGroupResponse retVal = new CompanyGroupResponse();
            DBT.TCompanyGroup dbCompanyGroup = new DBT.TCompanyGroup();

            if (request == null)
            {
                retVal.Success = false;
                retVal.ErrorHint = "Request is empty";
                retVal.TechnicalError = "DataModels.HrTrackServiceModels.CompanyGroup request is null";
                return retVal;
            }

            switch (request.Action)
            {
                case DataModels.HrTrackServiceModels.ActionType.Create:
                    {
                        DataModels.CompanyGroup dbCompanyGroupItem = Mapper.Map<DataModels.CompanyGroup>(request.CompanyGroupItem);

                        try
                        {
                            dbCompanyGroupItem.GroupGUID = Guid.NewGuid();

                            var successItem = dbCompanyGroup.CreatCompanyGroup(dbCompanyGroupItem);
                            if (successItem == null)
                            {
                                retVal.ErrorHint = "Failed to create item";
                                retVal.TechnicalError = "dbCompanyGroup.CreatCompanyGroup(dbCompanyGroupItem); failed.";
                                retVal.Success = false;
                                return retVal;
                            }

                            retVal.CompanyGroupItemList = new List<CompanyGroupItem>();
                            retVal.CompanyGroupItemList.Add(Mapper.Map<DataModels.HrTrackServiceModels.CompanyGroupItem>(successItem));
                        }
                        catch (Exception exc)
                        {
                            retVal.ErrorHint = "Failed to create item";
                            retVal.TechnicalError = exc.Message;
                            retVal.Success = false;
                            return retVal;
                        }
                    }
                    break;
                case DataModels.HrTrackServiceModels.ActionType.GetAll:
                    {
                        try
                        {
                            retVal.CompanyGroupItemList = new List<CompanyGroupItem>();
                            var dbCompanyGroupList = dbCompanyGroup.GetAllCompanyGroups();

                            foreach (var item in dbCompanyGroupList)
                            {
                                var res = Mapper.Map<DataModels.HrTrackServiceModels.CompanyGroupItem>(item);
                                retVal.CompanyGroupItemList.Add(res);
                            }
                        }
                        catch (Exception exc)
                        {

                        }
                    }
                    break;
            }

            return retVal;
        }

        public GroupPolicyResponse ProcessGroupPolicy(string format, GroupPolicyRequest request)
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "JSON";
            }

            switch (format.ToUpper())
            {
                case "XML":
                    {
                        WebOperationContext.Current.OutgoingResponse.Format = WebMessageFormat.Xml;
                    }
                    break;
                case "JSON":
                    {
                        WebOperationContext.Current.OutgoingResponse.Format = WebMessageFormat.Json;
                    }
                    break;
            }

            GroupPolicyResponse retVal = new GroupPolicyResponse();
            DBT.TGroupPolicy dbGroupPolicy = new DBT.TGroupPolicy();

            if (request == null)
            {
                retVal.Success = false;
                retVal.ErrorHint = "Request is empty";
                retVal.TechnicalError = "DataModels.HrTrackServiceModels.GroupPolicy request is null";
                return retVal;
            }

            switch (request.Action)
            {
                case DataModels.HrTrackServiceModels.ActionType.Create:
                    {
                        DataModels.GroupPolicies dbGroupPolicyItem = Mapper.Map<DataModels.GroupPolicies>(request.GroupPoliciesItem);

                        try
                        {
                            var successItem = dbGroupPolicy.CreatGroupPolicy(dbGroupPolicyItem);
                            if (successItem == null)
                            {
                                retVal.ErrorHint = "Failed to create item";
                                retVal.TechnicalError = "dbGroupPolicy.CreatGroupPolicy(dbGroupPolicyItem); failed.";
                                retVal.Success = false;
                                return retVal;
                            }

                            retVal.GroupPolicyItemList = new List<GroupPoliciesItem>();
                            retVal.GroupPolicyItemList.Add(Mapper.Map<DataModels.HrTrackServiceModels.GroupPoliciesItem>(successItem));
                        }
                        catch (Exception exc)
                        {
                            retVal.ErrorHint = "Failed to create item";
                            retVal.TechnicalError = exc.Message;
                            retVal.Success = false;
                            return retVal;
                        }
                    }
                    break;
                case DataModels.HrTrackServiceModels.ActionType.GetAll:
                    {
                        try
                        {
                            retVal.GroupPolicyItemList = new List<GroupPoliciesItem>();
                            var dbGroupPolicyList = dbGroupPolicy.GetAllGroupPolicies();

                            foreach (var item in dbGroupPolicyList)
                            {
                                var res = Mapper.Map<DataModels.HrTrackServiceModels.GroupPoliciesItem>(item);
                                retVal.GroupPolicyItemList.Add(res);
                            }
                        }
                        catch (Exception exc)
                        {

                        }
                    }
                    break;
            }

            return retVal;
        }
    }
}
