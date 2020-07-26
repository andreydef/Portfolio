using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using PortfolioApp.Models;
using PortfolioApp.Models.Main_models;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApp.Controllers
{
    [Route("api/stats")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        ApplicationContext db;

        public StatsController(ApplicationContext context)
        {
            db = context;
            if (!db.Stats.Any())
            {
                db.Stats.AddRange(
                   new Stats
                   {
                       Id = 1,
                       ImageName = "https://image.flaticon.com/icons/svg/126/126486.svg",
                       Count = 1500,
                       Title = "Projects completed"
                   },
                   new Stats
                   {
                       Id = 2,
                       ImageName = "https://image.flaticon.com/icons/svg/126/126486.svg",
                       Count = 900,
                       Title = "Happy clients"
                   },
                   new Stats
                   {
                       Id = 3,
                       ImageName = "https://image.flaticon.com/icons/svg/126/126486.svg",
                       Count = 200,
                       Title = "Awards received"
                   },
                   new Stats
                   {
                       Id = 4,
                       ImageName = "https://image.flaticon.com/icons/svg/126/126486.svg",
                       Count = 120,
                       Title = "Crazy Ideas"
                   },
                   new Stats
                   {
                       Id = 5,
                       ImageName = "https://image.flaticon.com/icons/svg/126/126486.svg",
                       Count = 1500,
                       Title = "Cofee Cups"
                   },
                   new Stats
                   {
                       Id = 6,
                       ImageName = "https://image.flaticon.com/icons/svg/126/126486.svg",
                       Count = 7200,
                       Title = "Hours"
                   });
                db.SaveChanges();
            }
            else
            {
                db.Stats.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Stats> Get()
        {
            return db.Stats.ToList();
        }

        [HttpGet("{id}")]
        public Stats Get(int id)
        {
            Stats stats = db.Stats.FirstOrDefault(x => x.Id == id);
            return stats;
        }

        [HttpPut]
        public IActionResult Put(Stats stats)
        {
            if (ModelState.IsValid)
            {
                db.Stats.Add(stats);
                db.SaveChanges();
                return Ok(stats);
            }
            return BadRequest(ModelState);
        }
    }
}