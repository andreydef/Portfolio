import { Component, OnInit } from '@angular/core';
import { Links } from '../Models/Links';
import { LinksService } from '../Services/links/links.service';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css'],
  providers: [ LinksService ]
})
export class FooterComponent implements OnInit {

  link: Links = new Links();
  links: Links[];

  constructor(private linksService: LinksService) { }

  loadLinks() {
    this.linksService.getLinks()
      .subscribe((data: Links[]) => this.links = data);
  }

  ngOnInit() {
    this.loadLinks();
  }
}
