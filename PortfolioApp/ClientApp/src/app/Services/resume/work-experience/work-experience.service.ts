import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { WorkExperience } from '../../../Models/Work_experience';

@Injectable()
export class WorkExperienceService {

  private url = 'api/work-experience';

  constructor(private http: HttpClient) { }

  getWorkExperiences() {
    return this.http.get(this.url);
  }

  getWorkExperience(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  updateWorkExperience(work: WorkExperience) {
    return this.http.put(this.url, work);
  }
}
