import { Component, OnInit } from '@angular/core';
import { User } from '../../Models/Auth/User';
import { UserRole } from '../../Models/Auth/Roles';
import { AuthService } from '../../Services/auth/auth.service';

import * as $ from 'jquery';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-admin-home',
  templateUrl: './admin-home.component.html',
  styleUrls: ['./admin-home.component.css']
})
export class AdminHomeComponent implements OnInit {

  isExpanded = false;
  userDataSubscription: any;
  userData = new User();
  userRole = UserRole;

  constructor(public titleService: Title,
    private authService: AuthService) {
    this.userDataSubscription = this.authService.userData.asObservable().subscribe(data => {
      this.userData = data;
    });
  }

  ngOnInit() {
    this.titleService.setTitle('Admin Panel');

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
