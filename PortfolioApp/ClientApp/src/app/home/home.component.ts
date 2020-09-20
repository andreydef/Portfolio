import { Component, OnInit } from '@angular/core';
import { Links } from '../Models/Links';
import { LinksService } from '../Services/links/links.service';
import { About } from '../Models/About';
import { AboutService } from '../Services/about/about.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  providers: [ LinksService, AboutService ]
})
export class HomeComponent implements OnInit {

  link: Links = new Links();
  links: Links[];

  about: About = new About();
  abouts: About[];

  constructor(private linkService: LinksService, private aboutService: AboutService) { }

  loadLinks() {
    this.linkService.getLinks()
      .subscribe((data: Links[]) => this.links = data);
  }

  loadAbouts() {
    this.aboutService.getAbouts()
      .subscribe((data: About[]) => this.abouts = data);
  }

  ngOnInit() {
    this.loadLinks();
    this.loadAbouts();
  }
}
