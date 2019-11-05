using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
    public class Education
    {
        public int EducationId { get; set; }

        public string Degree { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string School { get; set; }


    }
}
