using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using PortfolioApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApp.Controllers
{
    [Route("api/education")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        ApplicationContext db;

        public EducationController(ApplicationContext context)
        {
            db = context;
            if (!db.Education.Any())
            {
                db.Education.AddRange(
                     new Education
                     {
                         Id = 1,
                         Name_education = "Master Degree",
                         Date_start = new DateTime(2017, 05, 07),
                         Date_finish = DateTime.Now,
                         Title_place = "State Design University",
                         Description = "Lorem ipsum Occaecat do esse ex et dolor culpa nisi ex in magna consectetur nisi cupidatat laboris esse eiusmod deserunt aute do quis velit esse sed Ut proident cupidatat nulla esse cillum laborum occaecat nostrud sit dolor incididunt amet est occaecat nisi incididunt."
                     },
                     new Education
                     {
                         Id = 2,
                         Name_education = "Bachelor Degree",
                         Date_start = new DateTime(2014, 05, 07),
                         Date_finish = new DateTime(2019, 05, 04),
                         Title_place = "University of Life",
                         Description = "Lorem ipsum Occaecat do esse ex et dolor culpa nisi ex in magna consectetur nisi cupidatat laboris esse eiusmod deserunt aute do quis velit esse sed Ut proident cupidatat nulla esse cillum laborum occaecat nostrud sit dolor incididunt amet est occaecat nisi incididunt."
                     }
                    );
                db.SaveChanges();
            }
            else
            {
                db.Education.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Education> Get()
        {
            return db.Education.ToList();
        }

        [HttpGet("{id}")]
        public Education Get(int id)
        {
            Education education = db.Education.FirstOrDefault(x => x.Id == id);
            return education;
        }

        [HttpPut]
        public IActionResult Put(Education education)
        {
            if (ModelState.IsValid)
            {
                db.Education.Add(education);
                db.SaveChanges();
                return Ok(education);
            }
            return BadRequest(ModelState);
        }
    }
}