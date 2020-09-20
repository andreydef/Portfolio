import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ContactInfo } from './../../Models/Contact_info';
import { ContactMe } from './../../Models/Contact_me';

@Injectable()
export class ContactService {

  private contact_me = 'api/contact-me';
  private contact_info = 'api/contact-info';

  constructor(private http: HttpClient) { }

  getContactsInfo() {
    return this.http.get(this.contact_info);
  }

  getContactInfo(id: number) {
    return this.http.get(this.contact_info + '/' + id);
  }

  getContactsMe() {
    return this.http.get(this.contact_me);
  }

  getContactMe(id: number) {
    return this.http.get(this.contact_me + '/' + id);
  }

  updateContactInfo(contact_inf: ContactInfo) {
    return this.http.put(this.contact_info, contact_inf);
  }

  updateContactMe(contact_me: ContactMe) {
    return this.http.put(this.contact_me, contact_me);
  }
}
