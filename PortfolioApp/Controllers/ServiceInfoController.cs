using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using PortfolioApp.Models;
using PortfolioApp.Models.Main_models;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApp.Controllers
{
    [Route("api/service-info")]
    [ApiController]
    public class ServiceInfoController : ControllerBase
    {
        ApplicationContext db;

        public ServiceInfoController(ApplicationContext context)
        {
            db = context;
            if (!db.Service_info.Any())
            {
                db.Service_info.AddRange(
                    new Service_info
                    {
                        Id = 1,
                        ImageName = "",
                        Title = "Webdesign",
                        Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsamvoluptatem quia voluptas sit aspernatur aut odit aut fugit."
                    },
                    new Service_info
                    {
                        Id = 2,
                        ImageName = "",
                        Title = "WEb Development",
                        Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsamvoluptatem quia voluptas sit aspernatur aut odit aut fugit."
                    },
                    new Service_info
                    {
                        Id = 3,
                        ImageName = "",
                        Title = "Branding",
                        Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsamvoluptatem quia voluptas sit aspernatur aut odit aut fugit."
                    });
                db.SaveChanges();
            }
            else
            {
                db.Service_info.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Service_info> Get()
        {
            return db.Service_info.ToList();
        }

        [HttpGet("{id}")]
        public Service_info Get(int id)
        {
            Service_info service = db.Service_info.FirstOrDefault(x => x.Id == id);
            return service;
        }

        [HttpPut]
        public IActionResult Put(Service_info service)
        {
            if (ModelState.IsValid)
            {
                db.Service_info.Add(service);
                db.SaveChanges();
                return Ok(service);
            }
            return BadRequest(ModelState);
        }
    }
}