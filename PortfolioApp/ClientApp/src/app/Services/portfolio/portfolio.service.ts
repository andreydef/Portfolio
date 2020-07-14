import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Projects } from '../../Models/Main_models/Projects';

@Injectable()
export class PortfolioService {

  private url = 'api/project';

  constructor(private http: HttpClient) { }

  getPortfolios() {
    return this.http.get(this.url);
  }

  getPortfolio(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  updateResume(portfolio: Projects) {
    return this.http.put(this.url, portfolio);
  }

}
