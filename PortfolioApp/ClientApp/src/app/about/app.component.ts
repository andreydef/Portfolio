import { Component, OnInit } from '@angular/core';
import { AboutService } from '../Services/About/about.service';
import { About } from '../Models/Main_models/About';

@Component({
  selector: 'app-about',
  templateUrl: '../about/app.component.html',
  providers: [ AboutService ]
})
export class AboutComponent implements OnInit {

  about: About = new About();  // changed about
  abouts: About[];             // massif of abouts

  constructor(private aboutService: AboutService) { }

  // get data with service
  loadAbouts() {
    this.aboutService.getAbouts()
      .subscribe((data: About[]) => this.abouts = data);
  }

  ngOnInit() {
    this.loadAbouts(); // download data before the start of server
  }

  cancel() {
    this.about = new About();
  }

  // save data
  save() {
    if (this.about.id != null) {
      this.aboutService.updateAbout(this.about)
        .subscribe((data => this.loadAbouts()));
    }
    this.cancel();
  }

  editAbout(a: About) {
    this.about = a;
  }
}
