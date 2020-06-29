using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using PortfolioApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApp.Controllers
{
    [ApiController]
    [Route("api/about")]
    public class AboutController : Controller
    {
        ApplicationContext db;
        public AboutController(ApplicationContext context)
        {
            db = context;
            if (!db.About.Any())
            {
                db.About.Add(new About {
                    Title = "Let me introduce myself.",
                    ImageName = "",
                    Description = "Lorem ipsum Exercitation culpa qui dolor consequat exercitation fugiat laborum ex ea eiusmod ad do aliqua occaecat nisi ad irure sunt id pariatur Duis laboris amet exercitation veniam labore consectetur ea id quis eiusmod.",
                    Profile_desc = "Lorem ipsum Qui veniam ut consequat ex ullamco nulla in non ut esse in magna sint minim officia consectetur nisi commodo ea magna pariatur nisi cillum.",
                    FullName = "Juan Dela Cruz",
                    Birth_date = "September 28, 1987",
                    Job = "Freelancer, Frontend Developer",
                    Website = "www.kardswebsite.com",
                    Email = "me@kardswebsite.com",
                    Skills_desc = "Lorem ipsum Qui veniam ut consequat ex ullamco nulla in non ut esse in magna sint minim officia consectetur nisi commodo ea magna pariatur nisi cillum."
                });
                db.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<About> Get()
        {
            return db.About.ToList();
        }

        [HttpGet("{id}")]
        public About Get(int id)
        {
            About about = db.About.FirstOrDefault(x => x.Id == id);
            return about;
        }

        [HttpPost]
        public IActionResult Post(About about)
        {
            if (ModelState.IsValid)
            {
                db.About.Add(about);
                db.SaveChanges();
                return Ok(about);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put(About about)
        {
            if (ModelState.IsValid)
            {
                db.About.Add(about);
                db.SaveChanges();
                return Ok(about);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            About about = db.About.FirstOrDefault(x => x.Id == id);

            if (about != null)
            {
                db.About.Remove(about);
                db.SaveChanges();
            }
            return Ok(about);
        }
    }
}