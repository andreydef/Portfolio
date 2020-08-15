import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/app.component';
import { MyPortfolioComponent } from './my-portfolio/my-portfolio.component';
import { ResumeComponent } from './resume/resume.component';
import { MyServicesComponent } from './my-services/my-services.component';
import { StatsComponent } from './stats/stats.component';
import { ContactComponent } from './contact/contact.component';
import { ProjectsComponent } from './projects/projects.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';

import { LoginComponent } from './login/login.component';
import { AdminGuard } from './guards/admin.guard';
import { AdminHomeComponent } from './admin/admin-home/admin-home.component';

const appRoutes: Routes = [

  {
    path: '',
    component: HomeComponent,
    children: [
      { path: 'nav-menu', component: NavMenuComponent},
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
  {
    path: 'admin-home',
    component: AdminHomeComponent,
    canActivate: [AdminGuard],
    children: [
      // { path: 'home-admin', component: HomeAdminComponent}
    ]
  },

  // otherwise redirect to home
  { path: '**', redirectTo: '' }
];

export const routing = RouterModule.forRoot(appRoutes);
