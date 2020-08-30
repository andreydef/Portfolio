import { Component, OnInit } from '@angular/core';

import { User } from '../../Models/Auth/User';
import { UserRole } from '../../Models/Auth/Roles';
import { AuthService } from '../../Services/auth/auth.service';

import { Links } from '../../Models/Main_models/Links';
import { LinksService } from '../../Services/links/links.service';

import { About } from '../../Models/Main_models/About';
import { AboutService } from '../../Services/about/about.service';

import * as $ from 'jquery';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-home-admin',
  templateUrl: './home-admin.component.html',
  styleUrls: ['./home-admin.component.css'],
  providers: [ LinksService, AboutService ]
})
export class HomeAdminComponent implements OnInit {

  isExpanded = false;
  userDataSubscription: any;
  userData = new User();
  userRole = UserRole;

  link: Links = new Links();
  links: Links[];

  about: About = new About();
  abouts: About[];

  constructor(public titleService: Title,
    private authService: AuthService,
    private linkService: LinksService,
    private aboutService: AboutService) {
    this.userDataSubscription = this.authService.userData.asObservable().subscribe(data => {
      this.userData = data;
    });
  }

  loadLinks() {
    this.linkService.getLinks()
      .subscribe((data: Links[]) => this.links = data);
  }

  loadAbouts() {
    this.aboutService.getAbouts()
      .subscribe((data: About[]) => this.abouts = data);
  }

  ngOnInit() {
    this.titleService.setTitle('Home Admin');

    this.loadLinks();
    this.loadAbouts();

    // Add active state to sidbar nav links
    const path = window.location.href; // because the 'href' property of the DOM element is the absolute path
        $('#layoutSidenav_nav .sb-sidenav a.nav-link').each(function() {
            if (this.href === path) {
                $(this).addClass('active');
            }
        });

        // Toggle the side navigation
        $('#sidebarToggle').on('click', function(e) {
          e.preventDefault();
          $('body').toggleClass('sb-sidenav-toggled');
        });
  }

  logout() {
    this.authService.logout();
  }

}
