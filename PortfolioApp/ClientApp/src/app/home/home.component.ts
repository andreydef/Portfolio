import { Component, OnInit } from '@angular/core';
import { Links } from '../Models/Main_models/Links';
import { LinksService } from '../Services/links/links.service';
import { About } from '../Models/Main_models/About';
import { AboutService } from '../Services/about/about.service';

declare var $: any;

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

    // FitText Settings
    setTimeout(function() {
      $('#intro h1').fitText(1, { minFontSize: '42px', maxFontSize: '84px' });
    }, 100);

    // FitVids
    $('.fluid-video-wrapper').fitVids();


  }
}
