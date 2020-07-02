using Microsoft.AspNetCore.Mvc;
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

        public AboutController() { }

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