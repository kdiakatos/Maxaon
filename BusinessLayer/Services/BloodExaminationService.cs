using AutoMapper;
using BusinessLayer.Models;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class BloodExaminationService : IBloodExaminationService
    {
        private readonly IMapper _mapper;
        private readonly IBloodExaminationRepository _bloodExaminationRepository;

        public BloodExaminationService(IMapper mapper, IBloodExaminationRepository bloodExaminationRepository)
        {
            _mapper = mapper;
            _bloodExaminationRepository = bloodExaminationRepository;
        }

        public List<BloodExaminationViewModel> GetBloodExaminationsByUser(long amka)
        {
            var bloodExaminationList = new List<BloodExaminationViewModel>();
            var dbResult = _bloodExaminationRepository.GetBlooExaminationsByUser(amka);
            bloodExaminationList = _mapper.Map<List<BloodExaminationViewModel>>(dbResult);
            return bloodExaminationList;
        }

        public BloodExaminationViewModel CreateBloodExamination(BloodExaminationViewModel bloodExamination)
        {
            var dbRow = _mapper.Map<BloodExamination>(bloodExamination);
            var obj = _bloodExaminationRepository.CreateBloodExamination(dbRow);
            var result = _mapper.Map<BloodExaminationViewModel>(obj);
            return result;
        }
        public bool DeleteBloodExamination(int id)
        {
            var obj1 = _bloodExaminationRepository.DeleteBloodExamination(id);
            return obj1;
        }

        public BloodExaminationViewModel UpdateBloodExamination(BloodExaminationViewModel bloodExamination)
        {
            var dbRow = _mapper.Map<BloodExamination>(bloodExamination);
            var obj2 = _bloodExaminationRepository.UpdateBloodExamination(dbRow);
            var result = _mapper.Map<BloodExaminationViewModel>(obj2);
            return result;

        }
    }
}
