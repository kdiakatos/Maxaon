using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        public ActionResult AddBiochemicalExamination([FromBody] BiochemicalExamination biochemicalExamination)
        {
            var repo = new BiochemicalExaminationRepository();
            var createBio = repo.CreateBiochemicalExamination(biochemicalExamination);
            return Ok(createBio);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult DeleteBiochemicalExamination(int id)
        {
            var repo = new BiochemicalExaminationRepository();
            var deleteBio = repo.DeleteBiochemicalExamination(id);
            return Ok(deleteBio);
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

     
    }
}
