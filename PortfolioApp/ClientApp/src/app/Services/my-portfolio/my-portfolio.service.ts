import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Portfolio } from '../../Models/Portfolio';
import { Projects } from '../../Models/Projects';

@Injectable()
export class MyPortfolioService {

  private url = 'api/portfolio';
  private ulr_proj = 'api/projects';

  constructor(private http: HttpClient) { }

  getPortfolios() {
    return this.http.get(this.url);
  }

  getProjects() {
    return this.http.get(this.ulr_proj);
  }

  getPortfolio(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  getProject(id: number) {
    return this.http.get(this.ulr_proj + '/' + id);
  }

  updatePortfolio(portfolio: Portfolio) {
    return this.http.put(this.url, portfolio);
  }

  updateProject(projects: Projects) {
    return this.http.put(this.url, projects);
  }
}
