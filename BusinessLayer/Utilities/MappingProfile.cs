using AutoMapper;
using BusinessLayer.Models;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BiochemicalExamination, BiochemicalExaminationViewModel>();
            CreateMap<BiochemicalExaminationViewModel, BiochemicalExamination>();

            CreateMap<BloodExamination, BloodExaminationViewModel>();
            CreateMap<BloodExaminationViewModel, BloodExamination>();
        }
    }
}
