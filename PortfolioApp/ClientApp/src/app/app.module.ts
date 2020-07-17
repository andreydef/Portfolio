import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/app.component';
import { LoginComponent } from './Services/login/login.component';
import { ResumeComponent } from './resume/resume.component';
import { WorkExperienceComponent } from './work-experience/work-experience.component';
import { EducationComponent } from './education/education.component';
import { MyPortfolioComponent } from './my-portfolio/my-portfolio.component';
import { MyServicesComponent } from './my-services/my-services.component';
// import { AuthGuard } from './guards/auth.guard';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    AboutComponent,
    LoginComponent,
    ResumeComponent,
    WorkExperienceComponent,
    EducationComponent,
    MyPortfolioComponent,
    MyServicesComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'login', component: LoginComponent }
      // { path: 'about', component: AboutComponent },
      // { path: 'resume', component: ResumeComponent},
      // { path: 'user-home', component: UserHomeComponent, canActivate: [AuthGuard] },
      // { path: 'admin-home', component: AdminHomeComponent, canActivate: [AuthGuard] }
    ])
  ],
  providers: [],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
