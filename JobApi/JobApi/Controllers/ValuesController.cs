using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobApi.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace JobApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public List<JobInfo> Get()
        {
            JobDBContext jobdb = new JobDBContext();
            List<JobInfo> list = jobdb.JobInfo.ToList();
            return list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [EnableCors("any")]
        public List<JobInfo> Post()
        {
            JobDBContext jobdb = new JobDBContext();
            List<JobInfo> list = jobdb.JobInfo.ToList();
            return list;
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
