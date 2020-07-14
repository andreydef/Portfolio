import { Component, OnInit } from '@angular/core';
import { ServicesService } from '../Services/services/services.service';
import { Services } from '../Models/Main_models/Services';
@Component({
  selector: 'app-services-block',
  templateUrl: './services-block.component.html',
  styleUrls: ['./services-block.component.css'],
  providers: [ ServicesService ]
})
export class ServicesBlockComponent implements OnInit {

  service: Services = new Services();
  services: Services[];

  constructor(private serviceService: ServicesService) { }

  loadServices() {
    this.serviceService.getServices()
      .subscribe((data: Services[]) => this.services = data);
  }

  ngOnInit() {
    this.loadServices();
  }
}
