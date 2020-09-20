using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using PortfolioApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApp.Controllers
{
    [Route("api/work-experience")]
    [ApiController]
    public class WorkExperienceController : ControllerBase
    {
        ApplicationContext db;

        public WorkExperienceController(ApplicationContext context)
        {
            db = context;
            if (!db.Work_Experience.Any())
            {
                db.Work_Experience.AddRange(
                    new Work_Experience
                    {
                        Id = 1,
                        Name_job = "UI Designer",
                        Date_start = new DateTime(2015, 07, 05),
                        Date_finish = DateTime.Now,
                        Title_job = "Awesome Studio",
                        Description = "Lorem ipsum Occaecat do esse ex et dolor culpa nisi ex in magna consectetur nisi cupidatat laboris esse eiusmod deserunt aute do quis velit esse sed Ut proident cupidatat nulla esse cillum laborum occaecat nostrud sit dolor incididunt amet est occaecat nisi."
                    },
                    new Work_Experience
                    {
                        Id = 2,
                        Name_job = "Front-end Developer",
                        Date_start = new DateTime(2014, 07, 25),
                        Date_finish = new DateTime(2019, 04, 15),
                        Title_job = "Super Cool Agency",
                        Description = "Lorem ipsum Occaecat do esse ex et dolor culpa nisi ex in magna consectetur nisi cupidatat laboris esse eiusmod deserunt aute do quis velit esse sed Ut proident cupidatat nulla esse cillum laborum occaecat nostrud sit dolor incididunt amet est occaecat nisi incididunt."
                    }
                    );
                db.SaveChanges();
            }
            else
            {
                db.Work_Experience.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Work_Experience> Get()
        {
            return db.Work_Experience.ToList();
        }

        [HttpGet("{id}")]
        public Work_Experience Get(int id)
        {
            Work_Experience work = db.Work_Experience.FirstOrDefault(x => x.Id == id);
            return work;
        }
    }
}