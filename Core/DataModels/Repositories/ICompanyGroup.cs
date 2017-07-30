using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Repositories
{
    public interface ICompanyGroup
    {
        IEnumerable<CompanyGroup> GetAllCompanyGroups();

        CompanyGroup GetSingleCompanyGroupById(int id);

        CompanyGroup CreatCompanyGroup(CompanyGroup createItem);

        bool ModifyCompanyGroup(CompanyGroup modifiedItem);

        bool DeleteCompanyGroupByID(int id);
    }
}
