using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website.Models;
using Website.Data;
using Microsoft.EntityFrameworkCore;

namespace Website.Controllers
{   
    public class ResumeController : Controller
    {
        private ApplicationDbContext _context;

        public ResumeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {   
            var resume = new ResumeView();
            resume.Introduction = "Hello World";
            //getting null reference 
            resume.WorkExperience = _context.Experience.ToList();
            resume.Education = _context.Education.ToList();
            resume.SkillSets = _context.Skill.ToList();
            return View(resume);
        }
    }
}