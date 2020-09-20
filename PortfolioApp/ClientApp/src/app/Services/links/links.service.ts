import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Links } from './../../Models/Links';

@Injectable()
export class LinksService {

  private url = 'api/links';

  constructor(private http: HttpClient) { }

  getLinks() {
    return this.http.get(this.url);
  }

  getLink(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  updateLinks(links: Links) {
    return this.http.put(this.url, links);
  }
}
