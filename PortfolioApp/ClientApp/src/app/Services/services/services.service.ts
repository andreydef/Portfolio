import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Services } from '../../Models/Main_models/Services';

@Injectable()
export class ServicesService {

  private url = 'api/services';

  constructor(private http: HttpClient) { }

  getServices() {
    return this.http.get(this.url);
  }

  getService(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  updateResume(service: Services) {
    return this.http.put(this.url, service);
  }

}
