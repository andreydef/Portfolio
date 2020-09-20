using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using PortfolioApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApp.Controllers
{
    [Route("api/languages")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        ApplicationContext db;

        public LanguagesController(ApplicationContext context)
        {
            db = context;
            if (!db.Languages.Any())
            {
                db.Languages.AddRange(
                new Languages
                {
                    Id = 1,
                    Title = "HTML5",
                    Raiting = 90
                },
                new Languages
                {
                    Id = 2,
                    Title = "CSS3",
                    Raiting = 85
                },
                new Languages
                {
                    Id = 3,
                    Title = "JQUERY",
                    Raiting = 70
                },
                new Languages
                {
                    Id = 4,
                    Title = "PHP",
                    Raiting = 95
                },
                new Languages
                {
                    Id = 5,
                    Title = "WORDPRESS",
                    Raiting = 75
                }
                    );
                db.SaveChanges();
            }
            else
            {
                db.Languages.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Languages> Get()
        {
            return db.Languages.ToList();
        }

        [HttpGet("{id}")]
        public Languages Get(int id)
        {
            Languages lang = db.Languages.FirstOrDefault(x => x.Id == id);
            return lang;
        }
    }
}