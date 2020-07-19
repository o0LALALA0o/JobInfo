using System;
using System.Collections.Generic;

namespace JobApi.Models
{
    public partial class JobInfo
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string JobContent { get; set; }
        public string JobCo { get; set; }
        public DateTime? JobDate { get; set; }
        public int? IsDel { get; set; }
        public int? Visits { get; set; }
    }
}
