import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Education } from './../../../Models/Education';

@Injectable()
export class EducationService {

  private url = 'api/education';

  constructor(private http: HttpClient) { }

  getEducations() {
    return this.http.get(this.url);
  }

  getEducation(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  updateEducation(education: Education) {
    return this.http.put(this.url, education);
  }
}
