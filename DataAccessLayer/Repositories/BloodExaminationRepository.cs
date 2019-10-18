using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class BloodExaminationRepository
    {
        //Get all Blood independent of user
        public List<BloodExamination> GetAllExamination()
        {
            var allBloodExaminations = new List<BloodExamination>();
            var context = new MDTContext();
            allBloodExaminations = context.BloodExaminations.ToList();
            return allBloodExaminations;
        }

        // get blood amka
        public List<BloodExamination> GetBlooExaminationsByUser(long amka)
        {
            var bloodExamintationList = new List<BloodExamination>();
            using (var context = new MDTContext())
            {
                bloodExamintationList = context.BloodExaminations.Where(bl => bl.UserId.Value == amka).ToList();
            }
            return bloodExamintationList;
        }

        // Deete Blood Exam
        public bool DeleteBloodExamination(int id)
        {
            var deleteStatus = false;
            using (var context = new MDTContext())
            {
                var dbRow = context.BloodExaminations.Find(id);
                if (dbRow !=null)
                {
                    context.BloodExaminations.Remove(dbRow);
                    context.SaveChanges();
                    deleteStatus = true;
                }

            }
            return deleteStatus;

        }

        //Create bloodExamination
        public BloodExamination CreateBloodExamination(BloodExamination bloodExamination)
        {
            using (var context = new MDTContext())
            {
                context.BloodExaminations.Add(bloodExamination);
                context.SaveChanges();
            }
            return bloodExamination;
        }

        //Edit / Update
        public BloodExamination UpdateBloodExamination(BloodExamination bloodExamination)
        {
            using (var context = new MDTContext())
            {
                context.BloodExaminations.Update(bloodExamination);
                context.SaveChanges();
            }
            return bloodExamination;
        }
    }
}
