import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { NavMenuComponent } from './nav-menu/nav-menu.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers: [ NavMenuComponent ]
})
export class AppComponent implements OnInit {

  public constructor() {
  }

  ngOnInit() {
  }
}
