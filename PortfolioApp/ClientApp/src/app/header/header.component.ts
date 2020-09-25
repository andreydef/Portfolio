import { Component, OnInit } from '@angular/core';

import * as $ from 'jquery';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit  {
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
  }
}
