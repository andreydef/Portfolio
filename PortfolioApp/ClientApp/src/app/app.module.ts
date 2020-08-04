import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/app.component';
import { ResumeComponent } from './resume/resume.component';
import { WorkExperienceComponent } from './work-experience/work-experience.component';
import { EducationComponent } from './education/education.component';
import { MyPortfolioComponent } from './my-portfolio/my-portfolio.component';
import { MyServicesComponent } from './my-services/my-services.component';
import { StatsComponent } from './stats/stats.component';
import { ContactComponent } from './contact/contact.component';
import { ProjectsComponent } from './projects/projects.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { FooterComponent } from './footer/footer.component';

import { LoginComponent } from './login/login.component';

// import { AuthGuard } from './guards/auth.guard';

import { routing } from './app.routing';
import { AdminHomeComponent } from './admin/admin-home/admin-home.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavMenuComponent,
    AboutComponent,
    LoginComponent,
    ResumeComponent,
    WorkExperienceComponent,
    EducationComponent,
    MyPortfolioComponent,
    MyServicesComponent,
    StatsComponent,
    ContactComponent,
    ProjectsComponent,
    FooterComponent,
    AdminHomeComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    routing
  ],
  providers: [],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
