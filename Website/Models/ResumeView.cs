using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Data;

namespace Website.Models
{
    public class ResumeView
    {

        private ApplicationDbContext dataBase;
        public List<Skill> SkillSets { get; set; }

        public List<Education> Education { get; set; }

        public List<Experience> WorkExperience { get; set; }

        public string Introduction { get; set; }

        public ResumeView()
        {

        }
    }
}
