"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
exports.__esModule = true;
exports.AppModule = void 0;
var platform_browser_1 = require("@angular/platform-browser");
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var http_1 = require("@angular/common/http");
var app_component_1 = require("./app.component");
var home_component_1 = require("./home/home.component");
var app_component_2 = require("./about/app.component");
var resume_component_1 = require("./resume/resume.component");
var work_experience_component_1 = require("./work-experience/work-experience.component");
var education_component_1 = require("./education/education.component");
var my_portfolio_component_1 = require("./my-portfolio/my-portfolio.component");
var my_services_component_1 = require("./my-services/my-services.component");
var stats_component_1 = require("./stats/stats.component");
var contact_component_1 = require("./contact/contact.component");
var projects_component_1 = require("./projects/projects.component");
var nav_menu_component_1 = require("./nav-menu/nav-menu.component");
var footer_component_1 = require("./footer/footer.component");
var login_component_1 = require("./login/login.component");
// import { AuthGuard } from './guards/auth.guard';
var app_routing_1 = require("./app.routing");
var admin_home_component_1 = require("./admin/admin-home/admin-home.component");
var home_admin_component_1 = require("./admin/home-admin/home-admin.component");
var pagenotfound_component_1 = require("./pagenotfound/pagenotfound.component");
var admin_footer_component_1 = require("./admin/admin-footer/admin-footer.component");
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            declarations: [
                app_component_1.AppComponent,
                home_component_1.HomeComponent,
                nav_menu_component_1.NavMenuComponent,
                app_component_2.AboutComponent,
                login_component_1.LoginComponent,
                resume_component_1.ResumeComponent,
                work_experience_component_1.WorkExperienceComponent,
                education_component_1.EducationComponent,
                my_portfolio_component_1.MyPortfolioComponent,
                my_services_component_1.MyServicesComponent,
                stats_component_1.StatsComponent,
                contact_component_1.ContactComponent,
                projects_component_1.ProjectsComponent,
                footer_component_1.FooterComponent,
                admin_home_component_1.AdminHomeComponent,
                home_admin_component_1.HomeAdminComponent,
                pagenotfound_component_1.PagenotfoundComponent,
                admin_footer_component_1.AdminFooterComponent
            ],
            imports: [
                platform_browser_1.BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
                http_1.HttpClientModule,
                forms_1.FormsModule,
                forms_1.ReactiveFormsModule,
                app_routing_1.routing
            ],
            providers: [],
            bootstrap: [app_component_1.AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
