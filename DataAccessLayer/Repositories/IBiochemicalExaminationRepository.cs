using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public interface IBiochemicalExaminationRepository
    {
        List<BiochemicalExamination> GetAllExaminations();
        List<BiochemicalExamination> GetBiochemicalExaminationsByUser(long amka);
        bool DeleteBiochemicalExamination(int id);
        BiochemicalExamination CreateBiochemicalExamination(BiochemicalExamination biochemicalExamination);
        BiochemicalExamination UpdateBiochemicalExamination(BiochemicalExamination biochemicalExamination);
    }
}
