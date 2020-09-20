import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Languages } from '../../Models/Languages';

@Injectable()
export class LanguagesService {

  private url = 'api/languages';

  constructor(private http: HttpClient) { }

  getLanguages() {
    return this.http.get(this.url);
  }

  getLanguage(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  updateLanguages(lang: Languages) {
    return this.http.put(this.url, lang);
  }
}
