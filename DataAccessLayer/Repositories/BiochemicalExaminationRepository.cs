using DataAccessLayer.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class BiochemicalExaminationRepository : IBiochemicalExaminationRepository
    {
        //Get All Biochemical independent of user
        public List<BiochemicalExamination> GetAllExaminations()
        {
            var allBiochemicalExaminations = new List<BiochemicalExamination>();
            var context = new MDTContext();
            allBiochemicalExaminations = context.BiochemicalExaminations.ToList();
            return allBiochemicalExaminations;
        }

        //Fere analoga to AMKA
        public List<BiochemicalExamination> GetBiochemicalExaminationsByUser(long amka)
        {
            var biochemicalExaminationsList = new List<BiochemicalExamination>();
            using (var context = new MDTContext())
            {
                biochemicalExaminationsList = context.BiochemicalExaminations.Where(be => be.UserId.Value == amka).ToList();
            }
            return biochemicalExaminationsList;
        }
        //Delete 1os tropos
        //public void DeleteBiochemicalExamination1(int id)
        //{
        //    using (var context = new MDTContext())
        //    {
        //        var dbRow = context.BiochemicalExaminations.Find(id);
        //        if(dbRow != null)
        //        {
        //            context.BiochemicalExaminations.Remove(dbRow);
        //            context.SaveChanges();
        //        }              
        //    }

        //}

            //delete 2os tropos
        public bool DeleteBiochemicalExamination(int id)
        {
            var deleteStatus = false;
            using (var context = new MDTContext())
            {
                var dbRow = context.BiochemicalExaminations.Find(id);
                if (dbRow != null)
                {
                    context.BiochemicalExaminations.Remove(dbRow);
                    context.SaveChanges();
                    deleteStatus = true;
                }
            }
            return deleteStatus;

        }
        //create
        public BiochemicalExamination CreateBiochemicalExamination(BiochemicalExamination biochemicalExamination)
        {
            using (var context = new MDTContext())
            {
                context.BiochemicalExaminations.Add(biochemicalExamination);
                context.SaveChanges();
                //biochemicalExamination.BiochemicalResultId = biochemicalExamination.BiochemicalResultId;
            }
            return biochemicalExamination;
        }

        //update
        public BiochemicalExamination UpdateBiochemicalExamination(BiochemicalExamination biochemicalExamination)
        {
            using (var context = new MDTContext())
            {
                context.BiochemicalExaminations.Update(biochemicalExamination);
                context.SaveChanges();
            }
            return biochemicalExamination;
        }
    }
}
