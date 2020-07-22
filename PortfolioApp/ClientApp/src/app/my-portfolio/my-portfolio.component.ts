import { Component, OnInit } from '@angular/core';
import { MyPortfolioService } from '../Services/my-portfolio/my-portfolio.service';
import { Portfolio } from '../Models/Main_models/Portfolio';
import { Projects } from '../Models/Main_models/Projects';

@Component({
  selector: 'app-my-portfolio',
  templateUrl: './my-portfolio.component.html',
  styleUrls: ['./my-portfolio.component.css'],
  providers: [ MyPortfolioService ]
})
export class MyPortfolioComponent implements OnInit {

  project: Portfolio = new Portfolio();
  projects: Portfolio[];

  main_project: Projects = new Projects();
  main_projects: Projects[];

  constructor(private portfolioService: MyPortfolioService) { }

  loadPortfolios() {
    this.portfolioService.getPortfolios()
      .subscribe((data: Portfolio[]) => this.projects = data);
  }

  loadProjects() {
    this.portfolioService.getProjects()
      .subscribe((data: Projects[]) => this.main_projects = data);
  }

  ngOnInit() {
    this.loadPortfolios();
    this.loadProjects();
  }
}
