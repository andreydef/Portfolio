import { Component, OnInit } from '@angular/core';
import { AboutService } from '../Services/about/about.service';
import { About } from '../Models/Main_models/About';
import { Languages } from '../Models/Main_models/Languages';
import { LanguagesService } from '../Services/lang/languages.service';

@Component({
  selector: 'app-about',
  templateUrl: '../about/app.component.html',
  styleUrls: ['../about/app.component.css'],
  providers: [ AboutService, LanguagesService ]
})
export class AboutComponent implements OnInit {

  about: About = new About();  // changed about
  abouts: About[];             // massif of abouts

  language: Languages = new Languages();
  languages: Languages[];

  constructor(private aboutService: AboutService, private languagesService: LanguagesService) { }

  // get data with service
  loadAbouts() {
    this.aboutService.getAbouts()
      .subscribe((data: About[]) => this.abouts = data);
  }

  loadLanguages() {
    this.languagesService.getLanguages()
      .subscribe((data: Languages[]) => this.languages = data);
  }

  ngOnInit() {
    this.loadAbouts(); // download data before the start of server
    this.loadLanguages();
  }

  // cancel() {
  //   this.about = new About();
  // }

  // save data
  // save() {
  //   if (this.about.id != null) {
  //     this.aboutService.updateAbout(this.about)
  //       .subscribe((data => this.loadAbouts()));
  //   }
  //   this.cancel();
  // }

  // editAbout(a: About) {
  //   this.about = a;
  // }
}
