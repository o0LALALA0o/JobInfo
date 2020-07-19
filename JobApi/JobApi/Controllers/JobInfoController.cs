using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobApi.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace JobApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobInfoController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        [EnableCors("any")] //解决跨域问题
        public dynamic Post(JObject Job)
        {
            JobDBContext jobdb = new JobDBContext();
            int JobId = Convert.ToInt32(Job["JobId"]);
            JobInfo j = jobdb.JobInfo.Where(x => x.JobId == JobId).FirstOrDefault();
            List<JobImg> i = jobdb.JobImg.Where(x => x.JobId == JobId).ToList();

            var json = new {
                jobinfo = j,
                jobimg = i
            };

            return json;
        }
    }
}