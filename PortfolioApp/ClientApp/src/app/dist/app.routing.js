"use strict";
exports.__esModule = true;
exports.routing = void 0;
var pagenotfound_component_1 = require("./pagenotfound/pagenotfound.component");
var home_admin_component_1 = require("./admin/home-admin/home-admin.component");
var router_1 = require("@angular/router");
var home_component_1 = require("./home/home.component");
var app_component_1 = require("./about/app.component");
var my_portfolio_component_1 = require("./my-portfolio/my-portfolio.component");
var resume_component_1 = require("./resume/resume.component");
var my_services_component_1 = require("./my-services/my-services.component");
var stats_component_1 = require("./stats/stats.component");
var contact_component_1 = require("./contact/contact.component");
var projects_component_1 = require("./projects/projects.component");
var nav_menu_component_1 = require("./nav-menu/nav-menu.component");
var login_component_1 = require("./login/login.component");
var admin_guard_1 = require("./guards/admin.guard");
var admin_home_component_1 = require("./admin/admin-home/admin-home.component");
var appRoutes = [
    {
        path: '',
        component: home_component_1.HomeComponent,
        children: [
            { path: 'nav-menu', component: nav_menu_component_1.NavMenuComponent },
            { path: 'about', component: app_component_1.AboutComponent },
            { path: 'resume', component: resume_component_1.ResumeComponent },
            { path: 'portfolio', component: my_portfolio_component_1.MyPortfolioComponent },
            { path: 'services', component: my_services_component_1.MyServicesComponent },
            { path: 'stats', component: stats_component_1.StatsComponent },
            { path: 'contact', component: contact_component_1.ContactComponent }
        ]
    },
    // no layout routes
    { path: 'login', component: login_component_1.LoginComponent },
    { path: 'projects', component: projects_component_1.ProjectsComponent },
    // admin routings
    { path: 'admin-home', component: admin_home_component_1.AdminHomeComponent, canActivate: [admin_guard_1.AdminGuard] },
    { path: 'home-admin', component: home_admin_component_1.HomeAdminComponent, canActivate: [admin_guard_1.AdminGuard] },
    // otherwise redirect to home
    { path: '**', component: pagenotfound_component_1.PagenotfoundComponent }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
