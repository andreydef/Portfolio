using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using PortfolioApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApp.Controllers
{
    [Route("api/contact-me")]
    [ApiController]
    public class ContactMeController : ControllerBase
    {
        ApplicationContext db;

        public ContactMeController(ApplicationContext context)
        {
            db = context;
            if (!db.Contact_me.Any())
            {
                db.Contact_me.Add(
                    new Contact_me
                    {
                        Id = 1,
                        Title = "I'd Love To Hear From You.",
                        Description = "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do.",
                        Name = "Andriy",
                        Email = "andriyhalelyuka@ukr.net",
                        Subject = "Question",
                        Message = "Do you have some React job's in you portfolio?"
                    }
                    );
                db.SaveChanges();
            }
            else
            {
                db.Contact_me.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Contact_me> Get()
        {
            return db.Contact_me.ToList();
        }

        [HttpGet("{id}")]
        public Contact_me Get(int id)
        {
            Contact_me contact_me = db.Contact_me.FirstOrDefault(x => x.Id == id);
            return contact_me;
        }
    }
}