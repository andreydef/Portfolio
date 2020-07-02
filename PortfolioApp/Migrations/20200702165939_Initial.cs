using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    Profile_desc = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Birth_date = table.Column<DateTime>(nullable: false),
                    Job = table.Column<string>(nullable: false),
                    Website = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Skills_desc = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact_info",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 40, nullable: false),
                    Short_desc = table.Column<string>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    Link_facebook = table.Column<string>(nullable: false),
                    Link_github = table.Column<string>(nullable: false),
                    Link_twitter = table.Column<string>(nullable: false),
                    Link_instagram = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact_info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact_me",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Subject = table.Column<string>(nullable: false),
                    Message = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact_me", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_education = table.Column<string>(maxLength: 40, nullable: false),
                    Date_start = table.Column<DateTime>(nullable: false),
                    Date_finish = table.Column<DateTime>(nullable: false),
                    Title_place = table.Column<string>(maxLength: 40, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Info_jobs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numbers = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 40, nullable: false),
                    ImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info_jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 20, nullable: false),
                    Raiting = table.Column<int>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Main_info",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Main_info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name_project = table.Column<string>(maxLength: 40, nullable: false),
                    Date_project = table.Column<DateTime>(nullable: false),
                    ImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resume",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 40, nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resume", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 40, nullable: true),
                    Short_desc = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    Title_service = table.Column<string>(maxLength: 40, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    UserType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Work_Experience",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_job = table.Column<string>(maxLength: 40, nullable: false),
                    Date_start = table.Column<DateTime>(nullable: false),
                    Date_finish = table.Column<DateTime>(nullable: false),
                    Title_job = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Work_Experience", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "Birth_date", "Description", "Email", "FullName", "ImageName", "Job", "Profile_desc", "Skills_desc", "Title", "Website" },
                values: new object[] { 1, new DateTime(1987, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum Exercitation culpa qui dolor consequat exercitation fugiat laborum ex ea eiusmod ad do aliqua occaecat nisi ad irure sunt id pariatur Duis laboris amet exercitation veniam labore consectetur ea id quis eiusmod.", "me@kardswebsite.com", "Juan Dela Cruz", "", "Freelancer, Frontend Developer", "Lorem ipsum Qui veniam ut consequat ex ullamco nulla in non ut esse in magna sint minim officia consectetur nisi commodo ea magna pariatur nisi cillum.	", "Lorem ipsum Qui veniam ut consequat ex ullamco nulla in non ut esse in magna sint minim officia consectetur nisi commodo ea magna pariatur nisi cillum.", "Let me introduce myself.", "www.kardswebsite.com" });

            migrationBuilder.InsertData(
                table: "Contact_info",
                columns: new[] { "Id", "ImageName", "Link_facebook", "Link_github", "Link_instagram", "Link_twitter", "Short_desc", "Title" },
                values: new object[,]
                {
                    { 1, null, "https://www.facebook.com/profile.php?id=100009036657512", "https://github.com/andreydef", "https://www.instagram.com/_andriy_halelyuka_/", "https://twitter.com/Andriy346", "1600 Amphitheatre Parkway Mountain View, CA 94043 US", "WHERE TO FIND ME" },
                    { 2, null, "https://www.facebook.com/profile.php?id=100009036657512", "https://github.com/andreydef", "https://www.instagram.com/_andriy_halelyuka_/", "https://twitter.com/Andriy346", "someone@kardswebsite.com info@kardswebsite.com", "EMAIL ME AT" },
                    { 3, null, "https://www.facebook.com/profile.php?id=100009036657512", "https://github.com/andreydef", "https://www.instagram.com/_andriy_halelyuka_/", "https://twitter.com/Andriy346", "Phone: (+63) 555 1212 Mobile: (+63) 555 0100 Fax: (+63) 555 0101", "CALL ME AT" }
                });

            migrationBuilder.InsertData(
                table: "Contact_me",
                columns: new[] { "Id", "Description", "Email", "Message", "Name", "Subject", "Title" },
                values: new object[] { 1, "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do.", "andriyhalelyuka@ukr.net", "Do you have some React job's in you portfolio?", "Andriy", "Question", "I'd Love To Hear From You." });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Date_finish", "Date_start", "Description", "Name_education", "Title_place" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 2, 19, 59, 37, 889, DateTimeKind.Local).AddTicks(4235), new DateTime(2017, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum Occaecat do esse ex et dolor culpa nisi ex in magna consectetur nisi cupidatat laboris esse eiusmod deserunt aute do quis velit esse sed Ut proident cupidatat nulla esse cillum laborum occaecat nostrud sit dolor incididunt amet est occaecat nisi incididunt.", "Master Degree", "State Design University" },
                    { 2, new DateTime(2019, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum Occaecat do esse ex et dolor culpa nisi ex in magna consectetur nisi cupidatat laboris esse eiusmod deserunt aute do quis velit esse sed Ut proident cupidatat nulla esse cillum laborum occaecat nostrud sit dolor incididunt amet est occaecat nisi incididunt.", "Bachelor Degree", "University of Life" }
                });

            migrationBuilder.InsertData(
                table: "Info_jobs",
                columns: new[] { "Id", "ImageName", "Numbers", "Title" },
                values: new object[,]
                {
                    { 1, null, 1500, "PROJECTS COMPLETED" },
                    { 2, null, 900, "HAPPY CLIENTS" },
                    { 3, null, 200, "AWARDS RECEIVED" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Raiting", "Title" },
                values: new object[,]
                {
                    { 5, 75, "WORDPRESS" },
                    { 3, 70, "JQUERY" },
                    { 4, 95, "PHP" },
                    { 1, 90, "HTML5" },
                    { 2, 85, "CSS3" }
                });

            migrationBuilder.InsertData(
                table: "Main_info",
                columns: new[] { "Id", "Description", "ImageName", "Title" },
                values: new object[] { 1, "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do.", null, "Check Out Some of My Works." });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Date_project", "Description", "ImageName", "Name_project", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer posuere", null, "Website Contrast", "my latest works" },
                    { 2, new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Banking_system", null }
                });

            migrationBuilder.InsertData(
                table: "Resume",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do.", "More of my credentials." });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "ImageName", "Short_desc", "Title", "Title_service" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do.", null, "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do.", "What Can I Do For You?", "Web Development" },
                    { 2, "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do.", null, null, null, "Web Development" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Website" },
                    { 2, "Bank" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "FirstName", "Password", "UserName", "UserType" },
                values: new object[,]
                {
                    { 1, "Andriy", "a30072001", "anreydef", "User" },
                    { 2, "danger", "pass", "admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Work_Experience",
                columns: new[] { "Id", "Date_finish", "Date_start", "Description", "Name_job", "Title_job" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 2, 19, 59, 37, 886, DateTimeKind.Local).AddTicks(5578), new DateTime(2015, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum Occaecat do esse ex et dolor culpa nisi ex in magna consectetur nisi cupidatat laboris esse eiusmod deserunt aute do quis velit esse sed Ut proident cupidatat nulla esse cillum laborum occaecat nostrud sit dolor incididunt amet est occaecat nisi.", "UI Designer", "Awesome Studio" },
                    { 2, new DateTime(2019, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum Occaecat do esse ex et dolor culpa nisi ex in magna consectetur nisi cupidatat laboris esse eiusmod deserunt aute do quis velit esse sed Ut proident cupidatat nulla esse cillum laborum occaecat nostrud sit dolor incididunt amet est occaecat nisi incididunt.", "Front-end Developer", "Super Cool Agency" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "Contact_info");

            migrationBuilder.DropTable(
                name: "Contact_me");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Info_jobs");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Main_info");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Resume");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Work_Experience");
        }
    }
}
