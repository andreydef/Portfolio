import { Component, OnInit } from '@angular/core';
import { ServicesService } from '../Services/services/services.service';
import { Services } from '../Models/Main_models/Services';

@Component({
  selector: 'app-my-services',
  templateUrl: './my-services.component.html',
  styleUrls: ['./my-services.component.css'],
  providers: [ ServicesService ]
})
export class MyServicesComponent implements OnInit {

  service: Services = new Services();
  services: Services[];

  constructor(private servicesService: ServicesService) { }

  loadServices() {
    this.servicesService.getServices()
      .subscribe((data: Services[]) => this.services = data);
  }

  ngOnInit() {
    this.loadServices();
  }
}
