import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Portfolio } from '../../Models/Main_models/Portfolio';

@Injectable()
export class MyPortfolioService {

  private url = 'api/portfolio';

  constructor(private http: HttpClient) { }

  getPortfolios() {
    return this.http.get(this.url);
  }

  getPortfolio(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  updatePortfolio(portfolio: Portfolio) {
    return this.http.put(this.url, portfolio);
  }
}
