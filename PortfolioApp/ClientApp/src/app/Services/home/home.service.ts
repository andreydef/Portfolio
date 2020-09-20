import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Links } from '../../Models/Links';

@Injectable()
export class HomeService {

  private url = 'api/links';

  constructor(private http: HttpClient) { }

  getHomes() {
    return this.http.get(this.url);
  }

  getHome(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  updateHome(link: Links) {
    return this.http.put(this.url, link);
  }
}
