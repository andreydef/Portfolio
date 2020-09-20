import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { About } from '../../Models/About';

@Injectable()
export class AboutService {

  private url = 'api/about';

  constructor(private http: HttpClient) { }

  getAbouts() {
    return this.http.get(this.url);
  }

  getAbout(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  updateAbout(about: About) {
    return this.http.put(this.url, about);
  }
}
