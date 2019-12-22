using BusinessLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer.Services
{
    public interface IBiochemicalExaminationService
    {
        BiochemicalExaminationViewModel CreateBiochemicalExamination(BiochemicalExaminationViewModel biochemicalExamination);
        bool DeleteBiochemicalExamination(int id);
        List<BiochemicalExaminationViewModel> GetBiochemicalExaminationsByUser(long amka);
        BiochemicalExaminationViewModel UpdateBiochemicalExamination(BiochemicalExaminationViewModel biochemicalExamination);
    }
}