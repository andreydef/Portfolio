using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using PortfolioApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApp.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        ApplicationContext db;

        public ProjectsController(ApplicationContext context)
        {
            db = context;
            if (!db.Projects.Any())
            {
                db.Projects.AddRange(
                     new Projects
                     {
                         Id = 1,
                         Title = "my latest works",
                         Description = "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer posuere",
                         Name_project = "Website Contrast",
                         Date_project = new DateTime(2020, 05, 15)
                     },
                     new Projects
                     {
                         Id = 2,
                         Name_project = "Banking_system",
                         Date_project = new DateTime(2020, 06, 05)
                     }
                    );
                db.SaveChanges();
            }
            else
            {
                db.Projects.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Projects> Get()
        {
            return db.Projects.ToList();
        }

        [HttpGet("{id}")]
        public Projects Get(int id)
        {
            Projects proj = db.Projects.FirstOrDefault(x => x.Id == id);
            return proj;
        }

        [HttpPut]
        public IActionResult Put(Projects proj)
        {
            if (ModelState.IsValid)
            {
                db.Projects.Add(proj);
                db.SaveChanges();
                return Ok(proj);
            }
            return BadRequest(ModelState);
        }
    }
}