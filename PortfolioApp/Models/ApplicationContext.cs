using System;
using Microsoft.EntityFrameworkCore;
using PortfolioApp.Models.Main_models;

namespace PortfolioApp.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<About> About { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Resume> Resume { get; set; }
        public DbSet<Work_Experience> Work_Experience { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Main_info> Main_info { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Info_jobs> Info_jobs { get; set; }
        public DbSet<Contact_me> Contact_me { get; set; }
        public DbSet<Contact_info> Contact_info { get; set; }
        public DbSet<Portfolio> Portfolio { get; set; }
        public DbSet<Service_info> Service_info { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<Links> Links { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>().HasData(new About[]
            {
                new About
                {
                    Id = 1,
                    Title = "Let me introduce myself.",
                    ImageName = "",
                    Description = "Lorem ipsum Exercitation culpa qui dolor consequat exercitation fugiat laborum ex ea eiusmod ad do aliqua occaecat nisi ad irure sunt id pariatur Duis laboris amet exercitation veniam labore consectetur ea id quis eiusmod.",
                    Profile_desc = "Lorem ipsum Qui veniam ut consequat ex ullamco nulla in non ut esse in magna sint minim officia consectetur nisi commodo ea magna pariatur nisi cillum.	",
                    FullName = "Juan Dela Cruz",
                    Birth_date = new DateTime(1987, 05, 13),
                    Job = "Freelancer, Frontend Developer",
                    Website = "www.kardswebsite.com",
                    Email = "me@kardswebsite.com",
                    Skills_desc = "Lorem ipsum Qui veniam ut consequat ex ullamco nulla in non ut esse in magna sint minim officia consectetur nisi commodo ea magna pariatur nisi cillum."
                }
            });
            modelBuilder.Entity<Languages>().HasData(new Languages[]
            {
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
            });
            modelBuilder.Entity<Tags>().HasData(new Tags[]
            {
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
            });
            modelBuilder.Entity<Resume>().HasData(new Resume[]
            {
                new Resume
                {
                    Id = 1,
                    Title = "More of my credentials.",
                    Description = "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do."
                }
            });
            modelBuilder.Entity<Work_Experience>().HasData(new Work_Experience[]
            {
                new Work_Experience
                {
                    Id = 1,
                    Name_job = "UI Designer",
                    Date_start = new DateTime(2015, 07, 05),
                    Date_finish = DateTime.Now,
                    Title_job = "Awesome Studio",
                    Description = "Lorem ipsum Occaecat do esse ex et dolor culpa nisi ex in magna consectetur nisi cupidatat laboris esse eiusmod deserunt aute do quis velit esse sed Ut proident cupidatat nulla esse cillum laborum occaecat nostrud sit dolor incididunt amet est occaecat nisi."
                },
                new Work_Experience
                {
                    Id = 2,
                    Name_job = "Front-end Developer",
                    Date_start =  new DateTime(2014, 07, 25),
                    Date_finish = new DateTime(2019, 04, 15),
                    Title_job = "Super Cool Agency",
                    Description = "Lorem ipsum Occaecat do esse ex et dolor culpa nisi ex in magna consectetur nisi cupidatat laboris esse eiusmod deserunt aute do quis velit esse sed Ut proident cupidatat nulla esse cillum laborum occaecat nostrud sit dolor incididunt amet est occaecat nisi incididunt."
                }
            });
            modelBuilder.Entity<Education>().HasData(new Education[]
            {
                new Education
                {
                    Id = 1,
                    Name_education = "Master Degree",
                    Date_start = new DateTime(2017, 05, 07),
                    Date_finish = DateTime.Now,
                    Title_place = "State Design University",
                    Description = "Lorem ipsum Occaecat do esse ex et dolor culpa nisi ex in magna consectetur nisi cupidatat laboris esse eiusmod deserunt aute do quis velit esse sed Ut proident cupidatat nulla esse cillum laborum occaecat nostrud sit dolor incididunt amet est occaecat nisi incididunt."
                },
                new Education
                {
                    Id = 2,
                    Name_education = "Bachelor Degree",
                    Date_start = new DateTime(2014, 05, 07),
                    Date_finish = new DateTime(2019, 05, 04),
                    Title_place = "University of Life",
                    Description = "Lorem ipsum Occaecat do esse ex et dolor culpa nisi ex in magna consectetur nisi cupidatat laboris esse eiusmod deserunt aute do quis velit esse sed Ut proident cupidatat nulla esse cillum laborum occaecat nostrud sit dolor incididunt amet est occaecat nisi incididunt."
                }
            });
            modelBuilder.Entity<Main_info>().HasData(new Main_info[]
            {
                new Main_info
                {
                    Id = 1,
                    Title = "Check Out Some of My Works.",
                    Description = "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do.",
                }
            });
            modelBuilder.Entity<Projects>().HasData(new Projects[]
            {
                new Projects
                {
                    Id = 1,
                    Title = "my latest works",
                    Description = "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer posuere",
                    Name_project = "Website Contrast",
                    Date_project = new DateTime(2020, 05, 15)
                },
                new Projects
                {
                    Id = 2,
                    Name_project = "Banking_system",
                    Date_project = new DateTime(2020, 06, 05)
                }
            });
            modelBuilder.Entity<Services>().HasData(new Services[]
            {
                new Services
                {
                    Id = 1,
                    Title = "What Can I Do For You?",
                    Short_desc = "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do.",
                    Title_service = "Web Development",
                    Description = "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do."
                },
                new Services
                {
                    Id = 2,
                    Title_service = "Web Development",
                    Description = "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do."
                }
            });
            modelBuilder.Entity<Info_jobs>().HasData(new Info_jobs[]
            {
                new Info_jobs
                {
                    Id = 1,
                    Numbers = 1500,
                    Title = "PROJECTS COMPLETED"
                },
                new Info_jobs
                {
                    Id = 2,
                    Numbers = 900,
                    Title = "HAPPY CLIENTS"
                },
                new Info_jobs
                {
                    Id = 3,
                    Numbers = 200,
                    Title = "AWARDS RECEIVED"
                }
            });
            modelBuilder.Entity<Contact_me>().HasData(new Contact_me[]
            {
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
            });
            modelBuilder.Entity<Contact_info>().HasData(new Contact_info[]
            {
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
                }
            });
            modelBuilder.Entity<Portfolio>().HasData(new Portfolio[]
            {
                new Portfolio
                {
                    Id = 1,
                    Title = "Check Out Some of My Works.",
                    Description = "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do."
                }
            });
            modelBuilder.Entity<Service_info>().HasData(new Service_info[]
            {
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
                    Title = "Web Development",
                    Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsamvoluptatem quia voluptas sit aspernatur aut odit aut fugit."
                },
                new Service_info
                {
                    Id = 3,
                    ImageName = "",
                    Title = "Branding",
                    Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsamvoluptatem quia voluptas sit aspernatur aut odit aut fugit."
                }
            });
            modelBuilder.Entity<Stats>().HasData(new Stats[]
            {
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
                }
            });
            modelBuilder.Entity<Links>().HasData(new Links[]
            { 
                new Links
                {
                    Id = 1, 
                    Link_facebook = "https://www.facebook.com/profile.php?id=100009036657512",
                    Link_github = "https://github.com/andreydef",
                    Link_twitter = "https://twitter.com/Andriy346",
                    Link_instagram = "https://www.instagram.com/_andriy_halelyuka_/"
                }
            });
        }
    }
}