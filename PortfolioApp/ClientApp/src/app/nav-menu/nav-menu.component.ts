import { Component, OnInit } from '@angular/core';
import { User } from '../Models/Auth/User';
import { UserRole } from '../Models/Auth/Roles';
import { AuthService } from '../Services/auth/auth.service';

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
 
   var toggleButton = $('.menu-toggle'),
   nav = $('.main-navigation');

   // toggle button
   toggleButton.on('click', function(e) {

   e.preventDefault();
   toggleButton.toggleClass('is-clicked');
      nav.slideToggle();
   });

   // nav items
   nav.find('li a').on("click", function() {   
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
 
      var target = this.hash,
       $target = $(target);
 
       $('html, body').stop().animate({
          'scrollTop': $target.offset().top
       }, 800, 'swing', function () {
         window.location.hash = target;
       });
 
     });  

   /*---------------------------------------------------- */
  	/* Highlight the current section in the navigation bar
   ------------------------------------------------------ */

   var sections = $("section"),
	 navigation_links = $("#main-nav-wrap li a");	

	 sections.waypoint( {
     handler: function(direction) {
		 var active_section;

		 active_section = $('section#' + this.element.id);

		 if (direction === "up") active_section = active_section.prev();

		 var active_link = $('#main-nav-wrap a[href="#' + active_section.attr("id") + '"]');			
       navigation_links.parent().removeClass("current");
		  	active_link.parent().addClass("current");
		 }, 
		 offset: '25%'
   });
  }
}
