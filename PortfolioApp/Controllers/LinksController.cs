using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Models;
using PortfolioApp.Models.Main_models;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApp.Controllers
{
    [Route("api/links")]
    [ApiController]
    public class LinksController : ControllerBase
    {
        ApplicationContext db;

        public LinksController(ApplicationContext context)
        {
            db = context;
            if (!db.Links.Any())
            {
                db.Links.Add(
                    new Links
                    {
                        Id = 1,
                        Link_facebook = "https://www.facebook.com/profile.php?id=100009036657512",
                        Link_github = "https://github.com/andreydef",
                        Link_twitter = "https://twitter.com/Andriy346",
                        Link_instagram = "https://www.instagram.com/_andriy_halelyuka_/"
                    });
                db.SaveChanges();
            }
            else
            {
                db.Links.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Links> Get()
        {
            return db.Links.ToList();
        }

        [HttpGet("{id}")]
        public Links Get(int id)
        {
            Links links = db.Links.FirstOrDefault(x => x.Id == id);
            return links;
        }

        [HttpPut]
        public IActionResult Put(Links links)
        {
            if (ModelState.IsValid)
            {
                db.Links.Add(links);
                db.SaveChanges();
                return Ok(links);
            }
            return BadRequest(ModelState);
        }
    }
}