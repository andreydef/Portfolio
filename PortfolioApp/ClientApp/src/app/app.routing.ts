import { ProjectsComponent } from './projects/projects.component';
import { LoginComponent } from './Services/login/login.component';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/app.component';
import { MyPortfolioComponent } from './my-portfolio/my-portfolio.component';
import { ResumeComponent } from './resume/resume.component';
import { MyServicesComponent } from './my-services/my-services.component';
import { StatsComponent } from './stats/stats.component';
import { ContactComponent } from './contact/contact.component';
import { FooterComponent } from './footer/footer.component';

const appRoutes: Routes = [

  {
    path: '',
    component: HomeComponent,
    children: [
      { path: 'about', component: AboutComponent },
      { path: 'resume', component: ResumeComponent },
      { path: 'portfolio', component: MyPortfolioComponent },
      { path: 'services', component: MyServicesComponent },
      { path: 'stats', component: StatsComponent },
      { path: 'contact', component: ContactComponent }
    ]
  },

  // no layout routes
  { path: 'login', component: LoginComponent },
  { path: 'projects', component: ProjectsComponent },
  // { path: 'user-home', component: UserHomeComponent, canActivate: [AuthGuard] },
  // { path: 'admin-home', component: AdminHomeComponent, canActivate: [AuthGuard] }

  // otherwise redirect to home
  { path: '**', redirectTo: '' }
];

export const routing = RouterModule.forRoot(appRoutes);
