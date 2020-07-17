using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Models;
using PortfolioApp.Models.Main_models;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApp.Controllers
{
    [Route("api/portfolio")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        ApplicationContext db;

        public PortfolioController(ApplicationContext context)
        {
            db = context;
            if (!db.Portfolio.Any())
            {
                db.Portfolio.Add(
                    new Portfolio
                    {
                        Id = 1,
                        Title = "Check Out Some of My Works.",            
                        Description = "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do."
                    });
                db.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<Portfolio> Get()
        {
            return db.Portfolio.ToList();
        }

        [HttpGet("{id}")]
        public Portfolio Get(int id)
        {
            Portfolio portfolio = db.Portfolio.FirstOrDefault(x => x.Id == id);
            return portfolio;
        }

        [HttpPut]
        public IActionResult Put(Portfolio portfolio)
        {
            if (ModelState.IsValid)
            {
                db.Portfolio.Add(portfolio);
                db.SaveChanges();
                return Ok(portfolio);
            }
            return BadRequest(ModelState);
        }
    }
}