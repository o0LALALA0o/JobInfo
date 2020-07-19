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
    public class JobListController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        [EnableCors("any")] //解决跨域问题
        public dynamic Post(JObject json)
        {
            JobDBContext jobdb = new JobDBContext();
            List<JobInfo> l = new List<JobInfo>();
            string query = json["query"].ToString();
            int page = Convert.ToInt32(json["page"]);
            int limit = Convert.ToInt32(json["limit"]);

            if (string.IsNullOrEmpty(query))
            {
                l = jobdb.JobInfo.OrderByDescending(x => x.JobDate).ToList();
            }
            else
            {
                l = jobdb.JobInfo.Where(x => x.JobTitle.Contains(query)).OrderByDescending(x => x.JobDate).ToList();
            }

            //.Skip((page - 1) * limit).Take(limit)

            var j = new {
                list = l.Skip((page - 1) * limit).Take(limit),
                count = l.Count(),
            };
            
            return j;
        }
    }
}