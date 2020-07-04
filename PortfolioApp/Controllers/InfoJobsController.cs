using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using PortfolioApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApp.Controllers
{
    [Route("api/info-job")]
    [ApiController]
    public class InfoJobsController : ControllerBase
    {
        ApplicationContext db;

        public InfoJobsController(ApplicationContext context)
        {
            db = context;
            if (!db.Info_jobs.Any())
            {
                db.Info_jobs.AddRange(
                    new Info_jobs
                    {
                        Id = 1,
                        Numbers = 1500,
                        Title = "PROJECTS COMPLETED"
                    },
                    new Info_jobs
                    {
                        Id = 2,
                        Numbers = 900,
                        Title = "HAPPY CLIENTS"
                    },
                    new Info_jobs
                    {
                        Id = 3,
                        Numbers = 200,
                        Title = "AWARDS RECEIVED"
                    }
                    );
                db.SaveChanges();
            }
            else
            {
                db.Info_jobs.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Info_jobs> Get()
        {
            return db.Info_jobs.ToList();
        }

        [HttpGet("{id}")]
        public Info_jobs Get(int id)
        {
            Info_jobs info_jobs = db.Info_jobs.FirstOrDefault(x => x.Id == id);
            return info_jobs;
        }

        [HttpPut]
        public IActionResult Put(Info_jobs info_jobs)
        {
            if (ModelState.IsValid)
            {
                db.Info_jobs.Add(info_jobs);
                db.SaveChanges();
                return Ok(info_jobs);
            }
            return BadRequest(ModelState);
        }
    }
}