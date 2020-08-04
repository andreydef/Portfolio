import { Component, OnInit } from '@angular/core';
import { User } from '../Models/Auth/User';
import { UserRole } from '../Models/Auth/Roles';
import { AuthService } from '../Services/auth/auth.service';

import * as $ from 'jquery';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit  {
  isExpanded = false;
  userDataSubscription: any;
  userData = new User();
  userRole = UserRole;

  constructor(private authService: AuthService) {
    this.userDataSubscription = this.authService.userData.asObservable().subscribe(data => {
      this.userData = data;
    });
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  logout() {
    this.authService.logout();
  }

  ngOnInit() {

  /*-----------------------------------------------------*/
  /* Navigation Menu
   ------------------------------------------------------ */

   let toggleButton = $('.menu-toggle');
   let nav = $('.main-navigation');

   // toggle button
   toggleButton.on('click', function(e) {

   e.preventDefault();
   toggleButton.toggleClass('is-clicked');
      nav.slideToggle();
   });

   // nav items
   nav.find('li a').on('click', function() {
   // update the toggle button
   toggleButton.toggleClass('is-clicked');
   // fadeout the navigation panel
     nav.fadeOut();
   });

    /*---------------------------------------------------- */
    /* Smooth Scrolling
  	------------------------------------------------------ */
    $('.smoothscroll').on('click', function (e) {

      e.preventDefault();

      let target = this.hash,
       $target = $(target);

       $('html, body').stop().animate({
          'scrollTop': $target.offset().top
       }, 800, 'swing', function () {
         window.location.hash = target;
       });

     });
  }
}
