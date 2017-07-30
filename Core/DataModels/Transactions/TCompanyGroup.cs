using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Transactions
{
    public class TCompanyGroup : Repositories.ICompanyGroup
    {
        public CompanyGroup CreatCompanyGroup(CompanyGroup createItem)
        {
            using (HrTrackEntities db = new DataContext().Context)
            {
                try
                {
                    db.CompanyGroup.Add(createItem);
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

        public bool DeleteCompanyGroupByID(int id)
        {
            using (HrTrackEntities db = new DataContext().Context)
            {
                try
                {
                    db.Entry(db.CompanyGroup.Find(id)).State = System.Data.Entity.EntityState.Deleted;
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

        public IEnumerable<CompanyGroup> GetAllCompanyGroups()
        {
            using (HrTrackEntities db = new DataContext().Context)
            {
                try
                {
                    IEnumerable<CompanyGroup> collection = null;
                    collection = db.CompanyGroup;
                    return collection.ToList();
                }
                catch (Exception exc)
                {
                    Console.WriteLine("[Error] " + exc.Message);
                    return null;
                }
            }
        }

        public CompanyGroup GetSingleCompanyGroupById(int id)
        {
            using (HrTrackEntities db = new DataContext().Context)
            {
                try
                {
                    CompanyGroup retVal = new CompanyGroup();
                    retVal = db.CompanyGroup.Find(id);
                    return retVal;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("[Error] " + exc.Message);
                    return null;
                }
            }
        }

        public bool ModifyCompanyGroup(CompanyGroup modifiedItem)
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
