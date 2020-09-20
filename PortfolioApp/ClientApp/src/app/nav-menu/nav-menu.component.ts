import { Component, OnInit } from '@angular/core';

import * as $ from 'jquery';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit  {
  isExpanded = false;

  constructor() {
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  ngOnInit() {

  /*-----------------------------------------------------*/
  /* Navigation Menu
   ------------------------------------------------------ */

   const toggleButton = $('.menu-toggle');
   const nav = $('.main-navigation');

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
      const target = this.hash,
       $target = $(target);
       $('html, body').stop().animate({
          'scrollTop': $target.offset().top
       }, 800, 'swing', function () {
         window.location.hash = target;
       });
     });
  }
}
