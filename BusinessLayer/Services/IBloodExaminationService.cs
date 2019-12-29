using BusinessLayer.Models;
using DataAccessLayer.Entities;
using System.Collections.Generic;

namespace BusinessLayer.Services
{
    public interface IBloodExaminationService
    {
        BloodExaminationViewModel CreateBloodExamination(BloodExaminationViewModel bloodExamination);
        bool DeleteBloodExamination(int id);
        List<BloodExaminationViewModel> GetBloodExaminationsByUser(long amka);
        BloodExaminationViewModel UpdateBloodExamination(BloodExaminationViewModel bloodExamination);
    }
}