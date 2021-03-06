import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/app.component';
import { MyPortfolioComponent } from './my-portfolio/my-portfolio.component';
import { ResumeComponent } from './resume/resume.component';
import { StatsComponent } from './stats/stats.component';
import { ContactComponent } from './contact/contact.component';
import { ProjectsComponent } from './projects/projects.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';

const appRoutes: Routes = [

  {
    path: '',
    component: HomeComponent,
    children: [
      { path: 'nav-menu', component: NavMenuComponent},
      { path: 'about', component: AboutComponent },
      { path: 'resume', component: ResumeComponent },
      { path: 'portfolio', component: MyPortfolioComponent },
      { path: 'stats', component: StatsComponent },
      { path: 'contact', component: ContactComponent }
    ]
  },

  // no layout routes
  { path: 'projects', component: ProjectsComponent },

  // otherwise redirect to home
  { path: '**', component: PagenotfoundComponent }
];

export const routing = RouterModule.forRoot(appRoutes);
