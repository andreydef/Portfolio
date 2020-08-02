import { Component, OnInit } from '@angular/core';

import { ServicesService } from '../Services/services/services.service';
import { Services } from '../Models/Main_models/Services';
import { ServiceInfo } from '../Models/Main_models/Service_info';

@Component({
  selector: 'app-my-services',
  templateUrl: './my-services.component.html',
  styleUrls: ['./my-services.component.css'],
  providers: [ ServicesService ]
})
export class MyServicesComponent implements OnInit {

  service: Services = new Services();
  services: Services[];

  service_info: ServiceInfo = new ServiceInfo();
  service_infos: ServiceInfo[];

  constructor(private servicesService: ServicesService) { }

  loadServices() {
    this.servicesService.getServices()
      .subscribe((data: Services[]) => this.services = data);
  }

  loadServicesInfo() {
    this.servicesService.getServiceInfos()
      .subscribe((data: ServiceInfo[]) => this.service_infos = data);
  }

  ngOnInit() {
    this.loadServices();
    this.loadServicesInfo();
  }
}
