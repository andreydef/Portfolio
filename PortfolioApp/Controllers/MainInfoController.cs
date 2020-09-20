using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using PortfolioApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApp.Controllers
{
    [Route("api/main-info")]
    [ApiController]
    public class MainInfoController : ControllerBase
    {
        ApplicationContext db;

        public MainInfoController(ApplicationContext context)
        {
            db = context;
            if (!db.Main_info.Any())
            {
                db.Main_info.Add(
                    new Main_info
                    {
                        Id = 1,
                        Title = "Check Out Some of My Works.",
                        Description = "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do.",
                    }
                    );
                db.SaveChanges();
            }
            else
            {
                db.Main_info.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Main_info> Get()
        {
            return db.Main_info.ToList();
        }

        [HttpGet("{id}")]
        public Main_info Get(int id)
        {
            Main_info main_info = db.Main_info.FirstOrDefault(x => x.Id == id);
            return main_info;
        }
    }
}