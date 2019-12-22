using AutoMapper;
using BusinessLayer.Models;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class BiochemicalExaminationService : IBiochemicalExaminationService
    {
        private readonly IMapper _mapper;
        private readonly IBiochemicalExaminationRepository _biochemicalExaminationRepository;

        public BiochemicalExaminationService(IBiochemicalExaminationRepository biochemicalExaminationRepository, IMapper mapper)
        {
            _biochemicalExaminationRepository = biochemicalExaminationRepository;
            _mapper = mapper;
        }

        public List<BiochemicalExaminationViewModel> GetBiochemicalExaminationsByUser(long amka)
        {
            var dbResult = _biochemicalExaminationRepository.GetBiochemicalExaminationsByUser(amka);
            var biochemicalExaminationsList = _mapper.Map<List<BiochemicalExaminationViewModel>>(dbResult);
            return biochemicalExaminationsList;
        }

        public BiochemicalExaminationViewModel CreateBiochemicalExamination(BiochemicalExaminationViewModel biochemicalExamination)
        {
            var dbRow = _mapper.Map<BiochemicalExamination>(biochemicalExamination);
            var response = _biochemicalExaminationRepository.CreateBiochemicalExamination(dbRow);
            var result = _mapper.Map<BiochemicalExaminationViewModel>(response);
            return result;
        }

        public bool DeleteBiochemicalExamination(int id)
        {
            var result = _biochemicalExaminationRepository.DeleteBiochemicalExamination(id);
            return result;
        }

        public BiochemicalExaminationViewModel UpdateBiochemicalExamination(BiochemicalExaminationViewModel biochemicalExamination)
        {
            var dbRow = _mapper.Map<BiochemicalExamination>(biochemicalExamination);
            var response = _biochemicalExaminationRepository.UpdateBiochemicalExamination(dbRow);
            var result = _mapper.Map<BiochemicalExaminationViewModel>(response);
            return result;
        }
    }
}
