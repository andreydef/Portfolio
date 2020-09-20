import { Component, OnInit } from '@angular/core';
import { ContactInfo } from '../Models/Contact_info';
import { ContactMe } from '../Models/Contact_me';
import { ContactService } from '../Services/contact/contact.service';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css'],
  providers: [ ContactService ]
})
export class ContactComponent implements OnInit {

  contact_info: ContactInfo = new ContactInfo();
  contacts_info: ContactInfo[];

  contact_me: ContactMe = new ContactMe();
  contacts_me: ContactMe[];

  constructor(private contactService: ContactService) { }

  loadContactsInfo() {
    this.contactService.getContactsInfo()
      .subscribe((data: ContactInfo[]) => this.contacts_info = data);
  }

  loadContactsMe() {
    this.contactService.getContactsMe()
      .subscribe((data: ContactMe[]) => this.contacts_me = data);
  }

  ngOnInit() {
    this.loadContactsInfo();
    this.loadContactsMe();
  }
}
