using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.Models;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloodExaminationController : ControllerBase
    {
        private readonly IBloodExaminationService _bloodExaminationService;

        public BloodExaminationController(IBloodExaminationService bloodExaminationService)
        {
            
            _bloodExaminationService = bloodExaminationService;
        }

        [HttpGet("{amka}")]
        public ActionResult GetAllByUser(long amka)
        {
            
            var result = _bloodExaminationService.GetBloodExaminationsByUser(amka);
            return Ok(result);
        }
        [HttpPost]
        public ActionResult CreateBloodExamination(BloodExaminationViewModel bloodExaminationViewModel)
        {
            var result = _bloodExaminationService.CreateBloodExamination(bloodExaminationViewModel);
            return Ok(result);
        }

        [HttpPut]
        public ActionResult UpdateBloodExamination(BloodExaminationViewModel bloodExaminationViewModel)
        {
            var result = _bloodExaminationService.UpdateBloodExamination(bloodExaminationViewModel);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteBloodExamination(int id)
        {
            var result = _bloodExaminationService.DeleteBloodExamination(id);
            return Ok(result);
        }
    }
}