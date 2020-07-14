import { Component, OnInit } from '@angular/core';
import { PortfolioService } from '../Services/portfolio/portfolio.service';
import { Projects } from '../Models/Main_models/Projects';

@Component({
  selector: 'app-portfolio',
  templateUrl: './portfolio.component.html',
  styleUrls: ['./portfolio.component.css'],
  providers: [ PortfolioService ]
})
export class PortfolioComponent implements OnInit {

  portfolio: Projects = new Projects();
  portfolios: Projects[];

  constructor(private resumeService: PortfolioService) { }

  loadResumes() {
    this.resumeService.getPortfolios()
      .subscribe((data: Projects[]) => this.portfolios = data);
  }

  ngOnInit() {
    this.loadResumes();
  }
}
