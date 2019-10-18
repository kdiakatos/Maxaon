using AutoMapper;
using BusinessLayer.Models;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class BiochemicalExaminationService
    {
        private readonly IMapper _mapper;

        public BiochemicalExaminationService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<BiochemicalExaminationViewModel> GetBiochemicalExaminationsByUser(long amka)
        {
            var biochemicalExaminationsList = new List<BiochemicalExaminationViewModel>();

            var obj = new BiochemicalExaminationRepository();
            var dbResult = obj.GetBiochemicalExaminationsByUser(amka);

            biochemicalExaminationsList = _mapper.Map<List<BiochemicalExaminationViewModel>>(dbResult);

            return biochemicalExaminationsList;
        }

        public BiochemicalExaminationViewModel CreateBiochemicalExamination(BiochemicalExaminationViewModel biochemicalExamination)
        {
            var dbRow = _mapper.Map<BiochemicalExamination>(biochemicalExamination);
            var bioRep = new BiochemicalExaminationRepository();
            var odj2 = bioRep.CreateBiochemicalExamination(dbRow);
            var result = _mapper.Map<BiochemicalExaminationViewModel>(odj2);
            return result;
        }

        public bool DeleteBiochemicalExamination(int id)
        {
            var delBio = new BiochemicalExaminationRepository();
            var obj3 = delBio.DeleteBiochemicalExamination(id);
            return obj3;
        }

        public BiochemicalExaminationViewModel UpdateBiochemicalExamination(BiochemicalExaminationViewModel biochemicalExamination)
        {
            var dbRow = _mapper.Map<BiochemicalExamination>(biochemicalExamination);
            var bioRep = new BiochemicalExaminationRepository();
            var odj2 = bioRep.UpdateBiochemicalExamination(dbRow);
            var result = _mapper.Map<BiochemicalExaminationViewModel>(odj2);
            return result;
        }

        //private List<BiochemicalExaminationViewModel> Map(List<BiochemicalExamination> biochemicalExaminations)
        //{
        //    var list = new List<BiochemicalExaminationViewModel>();
        //    foreach (var item in biochemicalExaminations)
        //    {
        //        var obj = new BiochemicalExaminationViewModel();
        //        obj.UserId = item.UserId;
        //        obj.UA = item.UA;
        //        obj.K = item.K;
        //        list.Add(obj);
        //    }
        //    return list;
        //}
    }
}
