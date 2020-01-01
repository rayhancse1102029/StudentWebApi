using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Models;

namespace StudentWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        // GET api/values
        [HttpGet]
        public StudentModel Get()
        {

            StudentModel studentModel = new StudentModel();

            studentModel.Name = "Abu Rayhan";
            studentModel.Dept = "CSE";
            studentModel.Cgpa = 3.30;
            studentModel.Year = 2019;

            studentModel.Name = "kaku";
            studentModel.Dept = "CSE";
            studentModel.Cgpa = 3.65;
            studentModel.Year = 2019;

            return studentModel;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
