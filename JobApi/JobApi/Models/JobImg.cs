using System;
using System.Collections.Generic;

namespace JobApi.Models
{
    public partial class JobImg
    {
        public int ImgId { get; set; }
        public int? JobId { get; set; }
        public string ImgName { get; set; }
        public int? ImgOrder { get; set; }
    }
}
