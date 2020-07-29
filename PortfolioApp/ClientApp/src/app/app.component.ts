import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { AuthService } from './Services/auth/auth.service';
import { NavMenuComponent } from './nav-menu/nav-menu.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers: [ NavMenuComponent ]
})
export class AppComponent implements OnInit {

  public constructor(public titleService: Title,
    private authService: AuthService) {
    if (localStorage.getItem('authToken')) {
      this.authService.setUserDetails();
    }
  }

  ngOnInit() {
  }
}
