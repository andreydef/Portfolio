import { Component, OnInit } from '@angular/core';
import { WorkExperienceService } from '../../Services/resume/work-experience/work-experience.service';
import { WorkExperience } from '../../Models/Main_models/Work_experience';

@Component({
  selector: 'app-work-experience',
  templateUrl: './work-experience.component.html',
  styleUrls: ['./work-experience.component.css'],
  providers: [ WorkExperienceService ]
})
export class WorkExperienceComponent implements OnInit {

  work: WorkExperience = new WorkExperience();
  works: WorkExperience[];

  constructor(private workService: WorkExperienceService) { }

  loadWorks() {
    this.workService.getWorkExperiences()
      .subscribe((data: WorkExperience[]) => this.works = data);
  }

  ngOnInit() {
    this.loadWorks();
  }

}
