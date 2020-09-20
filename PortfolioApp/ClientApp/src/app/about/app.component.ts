import { Component, OnInit } from '@angular/core';
import { AboutService } from '../Services/about/about.service';
import { About } from '../Models/About';
import { Languages } from '../Models/Languages';
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
}
