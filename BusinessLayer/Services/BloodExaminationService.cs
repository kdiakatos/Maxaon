using AutoMapper;
using BusinessLayer.Models;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class BloodExaminationService
    {
        private readonly IMapper _mapper;

        public BloodExaminationService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<BloodExaminationViewModel> GetBloodExaminationsByUser(long amka)
        {
            var bloodExaminationList = new List<BloodExaminationViewModel>();
            var obj = new BloodExaminationRepository();
            var dbResult = obj.GetBlooExaminationsByUser(amka);
            bloodExaminationList = _mapper.Map<List<BloodExaminationViewModel>>(dbResult);
            return bloodExaminationList;
        }

        public BloodExaminationViewModel CreateBloodExamination(BloodExaminationViewModel bloodExamination)
        {
            var dbRow = _mapper.Map<BloodExamination>(bloodExamination);
            var blRep = new BloodExaminationRepository();
            var obj = blRep.CreateBloodExamination(dbRow);
            var result = _mapper.Map<BloodExaminationViewModel>(obj);
            return result;
        }
        public bool DeleteBloodExamination(int id)
        {
            var delBl = new BloodExaminationRepository();
            var obj1 = delBl.DeleteBloodExamination(id);
            return obj1;
        }

        public BloodExaminationViewModel UpdateBloodExamination(BloodExamination bloodExamination)
        {
            var dbRow = _mapper.Map<BloodExamination>(bloodExamination);
            var blRep = new BloodExaminationRepository();
            var obj2 = blRep.UpdateBloodExamination(dbRow);
            var result = _mapper.Map<BloodExaminationViewModel>(obj2);
            return result;

        }
    }
}
