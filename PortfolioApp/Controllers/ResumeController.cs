using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using PortfolioApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApp.Controllers
{
    [Route("api/resume")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        ApplicationContext db;

        public ResumeController(ApplicationContext context)
        {
            db = context;
            if (!db.Resume.Any())
            {
                db.Resume.Add(
                    new Resume
                    {
                        Id = 1,
                        Title = "More of my credentials.",
                        Description = "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do."
                    }
                    );
                db.SaveChanges();
            }
            else
            {
                db.Resume.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Resume> Get()
        {
            return db.Resume.ToList();
        }

        [HttpGet("{id}")]
        public Resume Get(int id)
        {
            Resume resume = db.Resume.FirstOrDefault(x => x.Id == id);
            return resume;
        }

        [HttpPut]
        public IActionResult Put(Resume resume)
        {
            if (ModelState.IsValid)
            {
                db.Resume.Add(resume);
                db.SaveChanges();
                return Ok(resume);
            }
            return BadRequest(ModelState);
        }
    }
}