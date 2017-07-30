using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Repositories
{
    public interface IGroupPolicy
    {
        IEnumerable<GroupPolicies> GetAllGroupPolicies();

        GroupPolicies GetSingleGroupPolicyById(int id);

        GroupPolicies CreatGroupPolicy(GroupPolicies createItem);

        bool ModifyGroupPolicy(GroupPolicies modifiedItem);

        bool DeleteGroupPolicyByID(int id);
    }
}
