import { Title } from '@angular/platform-browser';
import { Component, OnInit } from '@angular/core';
import { Projects } from '../Models/Main_models/Projects';
import { ProjectsService } from '../Services/projects/projects.service';

@Component({
  selector: 'app-projects',
  templateUrl: './projects.component.html',
  styleUrls: ['./projects.component.css'],
  providers: [ ProjectsService ]
})
export class ProjectsComponent implements OnInit {

  project: Projects = new Projects();
  projects: Projects[];

  constructor(public titleService: Title,
    private projectsService: ProjectsService) { }

  loadProjects() {
    this.projectsService.getProjects()
      .subscribe((data: Projects[]) => this.projects = data);
  }

  ngOnInit() {
    this.loadProjects();
    this.titleService.setTitle('Projects');
  }
}
