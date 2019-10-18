using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class VisitRepository
    {
        public Visit CreateVisit(Visit visit)
        {
            using (var context = new MDTContext())
            {
                context.Visits.Add(visit);
                context.SaveChanges();
            }
            return visit;
        }

        public bool DeleteVisit(int id)
        {
            var status = false;
            using (var context = new MDTContext())
            {
                var obj = context.Visits.SingleOrDefault(x => x.VisitId == id);
                if (obj != null)
                {
                    context.Visits.Remove(obj);
                    context.SaveChanges();
                    status = true;
                }
            }
            return status;
        }
    }
}
