using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using PortfolioApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApp.Controllers
{
    [Route("api/contact-info")]
    [ApiController]
    public class ContactInfoController : ControllerBase
    {
        ApplicationContext db;

        public ContactInfoController(ApplicationContext context)
        {
            db = context;
            if (!db.Contact_info.Any())
            {
                db.Contact_info.AddRange(
                    new Contact_info
                    {
                        Id = 1,
                        Title = "WHERE TO FIND ME",
                        Short_desc = "1600 Amphitheatre Parkway Mountain View, CA 94043 US",
                        ImageName = "https://image.flaticon.com/icons/svg/126/126470.svg"
                    },
                    new Contact_info
                    {
                        Id = 2,
                        Title = "EMAIL ME AT",
                        Short_desc = "someone@kardswebsite.com info@kardswebsite.com",
                        ImageName = "https://image.flaticon.com/icons/svg/126/126470.svg"
                    },
                    new Contact_info
                    {
                        Id = 3,
                        Title = "CALL ME AT",
                        Short_desc = "Phone: (+63) 555 1212 Mobile: (+63) 555 0100 Fax: (+63) 555 0101",
                        ImageName = "https://image.flaticon.com/icons/svg/126/126470.svg"
                    });
                db.SaveChanges();
            }
            else
            {
                db.Contact_info.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Contact_info> Get()
        {
            return db.Contact_info.ToList();
        }

        [HttpGet("{id}")]
        public Contact_info Get(int id)
        {
            Contact_info contact = db.Contact_info.FirstOrDefault(x => x.Id == id);
            return contact;
        }

        [HttpPut]
        public IActionResult Put(Contact_info contact)
        {
            if (ModelState.IsValid)
            {
                db.Contact_info.Add(contact);
                db.SaveChanges();
                return Ok(contact);
            }
            return BadRequest(ModelState);
        }
    }
}