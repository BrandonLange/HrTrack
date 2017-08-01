using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrTrackServiceHost.Startup
{
    public class InitialiseAutoMapper
    {
        public InitialiseAutoMapper()
        {

        }

        public void StartAutoMapper()
        {
            Mapper.Initialize(x => {
                x.CreateMap<DataModels.GroupPolicies, DataModels.HrTrackServiceModels.GroupPoliciesItem>();
                x.CreateMap<DataModels.HrTrackServiceModels.GroupPoliciesItem, DataModels.GroupPolicies>();

                x.CreateMap<DataModels.CompanyGroup, DataModels.HrTrackServiceModels.CompanyGroupItem>();
                x.CreateMap<DataModels.HrTrackServiceModels.CompanyGroupItem, DataModels.CompanyGroup>();
            });
        }
    }
}
