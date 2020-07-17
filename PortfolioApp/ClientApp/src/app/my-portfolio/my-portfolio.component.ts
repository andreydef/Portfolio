import { Component, OnInit } from '@angular/core';
import { MyPortfolioService } from '../Services/my-portfolio/my-portfolio.service';
import { Portfolio } from '../Models/Main_models/Portfolio';

@Component({
  selector: 'app-my-portfolio',
  templateUrl: './my-portfolio.component.html',
  styleUrls: ['./my-portfolio.component.css'],
  providers: [ MyPortfolioService ]
})
export class MyPortfolioComponent implements OnInit {

  project: Portfolio = new Portfolio();
  projects: Portfolio[];

  constructor(private portfolioService: MyPortfolioService) { }

  loadPortfolios() {
    this.portfolioService.getPortfolios()
      .subscribe((data: Portfolio[]) => this.projects = data);
  }

  ngOnInit() {
    this.loadPortfolios();
  }
}
