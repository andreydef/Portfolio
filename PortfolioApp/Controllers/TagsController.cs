using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using PortfolioApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApp.Controllers
{
    [Route("api/tags")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        ApplicationContext db;

        public TagsController(ApplicationContext context)
        {
            db = context;
            if (!db.Languages.Any())
            {
                db.Tags.AddRange(
                    new Tags
                    {
                        Id = 1,
                        Title = "Website"
                    },
                    new Tags
                    {
                        Id = 2,
                        Title = "Bank"
                    }
                    );
                db.SaveChanges();
            }
            else
            {
                db.Tags.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Tags> Get()
        {
            return db.Tags.ToList();
        }

        [HttpGet("{id}")]
        public Tags Get(int id)
        {
            Tags tags = db.Tags.FirstOrDefault(x => x.Id == id);
            return tags;
        }
    }
}