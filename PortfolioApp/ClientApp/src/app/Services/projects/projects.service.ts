import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Projects } from '../../Models/Main_models/Projects';

@Injectable()
export class ProjectsService {

  private url = 'api/projects';

  constructor(private http: HttpClient) { }

  getProjects() {
    return this.http.get(this.url);
  }

  getProject(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  updateProjects(proj: Projects) {
    return this.http.put(this.url, proj);
  }
}
