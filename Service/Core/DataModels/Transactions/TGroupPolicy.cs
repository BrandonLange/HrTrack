using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Transactions
{
    public class TGroupPolicy : Repositories.IGroupPolicy
    {
        public GroupPolicies CreatGroupPolicy(GroupPolicies createItem)
        {
            using (HrTrackEntities db = new DataContext().Context)
            {
                try
                {
                    db.GroupPolicies.Add(createItem);
                    db.SaveChanges();
                    return createItem;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("[Error] " + exc.Message);
                    return null;
                }
            }
        }

        public bool DeleteGroupPolicyByID(int id)
        {
            using (HrTrackEntities db = new DataContext().Context)
            {
                try
                {
                    db.Entry(db.GroupPolicies.Find(id)).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("[Error] " + exc.Message);
                    return false;
                }
            }
        }

        public IEnumerable<GroupPolicies> GetAllGroupPolicies()
        {
            using (HrTrackEntities db = new DataContext().Context)
            {
                try
                {
                    IEnumerable<GroupPolicies> collection = null;
                    collection = db.GroupPolicies;
                    return collection.ToList();
                }
                catch (Exception exc)
                {
                    Console.WriteLine("[Error] " + exc.Message);
                    return null;
                }
            }
        }

        public GroupPolicies GetSingleGroupPolicyById(int id)
        {
            using (HrTrackEntities db = new DataContext().Context)
            {
                try
                {
                    GroupPolicies retVal = new GroupPolicies();
                    retVal = db.GroupPolicies.Find(id);
                    return retVal;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("[Error] " + exc.Message);
                    return null;
                }
            }
        }

        public bool ModifyGroupPolicy(GroupPolicies modifiedItem)
        {
            using (HrTrackEntities db = new DataContext().Context)
            {
                try
                {
                    db.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("[Error] " + exc.Message);
                    return false;
                }
            }
        }
    }
}
