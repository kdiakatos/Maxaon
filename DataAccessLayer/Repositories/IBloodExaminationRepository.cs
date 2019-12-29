using DataAccessLayer.Entities;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
    public interface IBloodExaminationRepository
    {
        BloodExamination CreateBloodExamination(BloodExamination bloodExamination);
        bool DeleteBloodExamination(int id);
        List<BloodExamination> GetAllExamination();
        List<BloodExamination> GetBlooExaminationsByUser(long amka);
        BloodExamination UpdateBloodExamination(BloodExamination bloodExamination);
    }
}