using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.Models;
using BusinessLayer.Services;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiochemicalExaminationController : ControllerBase
    {
        private readonly IMapper _mapper;

        public BiochemicalExaminationController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET api/values/5
        [HttpGet("{amka}")]
        public ActionResult GetBiochemicalExaminationsByUser(long amka)
        {
            var obj = new BiochemicalExaminationService(_mapper);
            var value = obj.GetBiochemicalExaminationsByUser(amka);
            return Ok(value);
        }

        [HttpPost]
        public ActionResult AddBiochemicalExamination([FromBody] BiochemicalExaminationViewModel biochemicalExamination)
        {
            var obj = new BiochemicalExaminationService(_mapper);
            var value = obj.CreateBiochemicalExamination(biochemicalExamination);
            return Ok(value);

        }
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult DeleteBiochemicalExamination(int id)
        {
            var repo = new BiochemicalExaminationService(_mapper);
            var deleteBio = repo.DeleteBiochemicalExamination(id);
            return Ok(deleteBio);
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] BiochemicalExaminationViewModel biochemicalExamination)
        {
            var obj = new BiochemicalExaminationService(_mapper);
            var value = obj.UpdateBiochemicalExamination(biochemicalExamination);
            return Ok(value);
        }

        [HttpGet]
        [Route("GetKsum")]
        public ActionResult GetKSum([FromQuery]long amka)
        {
            var obj = new BiochemicalExaminationService(_mapper);
            var value = obj.GetBiochemicalExaminationsByUser(amka);
            var x = new List<float>();
            foreach (var item in value)
            {
                x.Add(item.K);
            }
            var bbb = new CalculationService();
            var av = bbb.Average(x);
            return Ok(av);
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
     
    }
}
