import { Component, OnInit } from '@angular/core';
import { EducationService } from '../Services/resume/education/education.service';
import { Education } from '../Models/Education';

@Component({
  selector: 'app-education',
  templateUrl: './education.component.html',
  styleUrls: ['./education.component.css'],
  providers: [ EducationService ]
})
export class EducationComponent implements OnInit {

  education: Education = new Education();
  educations: Education[];

  constructor(private educationService: EducationService) { }

  loadEducations() {
    this.educationService.getEducations()
      .subscribe((data: Education[]) => this.educations = data);
  }

  ngOnInit() {
    this.loadEducations();
  }
}
