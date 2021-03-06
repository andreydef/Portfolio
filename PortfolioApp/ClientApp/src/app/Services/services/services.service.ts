import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Services } from '../../Models/Services';
import { ServiceInfo } from '../../Models/Service_info';

@Injectable()
export class ServicesService {

  private url = 'api/services';
  private url_service = 'api/service-info';

  constructor(private http: HttpClient) { }

  getServices() {
    return this.http.get(this.url);
  }

  getServiceInfos() {
    return this.http.get(this.url_service);
  }

  getService(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  getServiceInfo(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  updateService(service: Services) {
    return this.http.put(this.url, service);
  }

  updateServiceInfo(service_info: ServiceInfo) {
    return this.http.put(this.url, service_info);
  }
}
