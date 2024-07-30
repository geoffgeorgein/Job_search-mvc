using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_search.Models
{
    public class Job
    {
        [Required(ErrorMessage = "Enter the Company ID")]
        public int Company_id { get; set; }

        [Required(ErrorMessage = "Enter the skills")]
        public string Skills { get; set; }
        [Required(ErrorMessage = "Enter the Experience")]
        public int Experience { get; set; }
        public string Last_date { get; set; }

      



    }
}