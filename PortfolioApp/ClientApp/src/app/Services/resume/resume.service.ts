import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Resume } from '../../Models/Resume';

@Injectable()
export class ResumeService {

  private url = 'api/resume';

  constructor(private http: HttpClient) { }

  getResumes() {
    return this.http.get(this.url);
  }

  getResume(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  updateResume(resume: Resume) {
    return this.http.put(this.url, resume);
  }

}
