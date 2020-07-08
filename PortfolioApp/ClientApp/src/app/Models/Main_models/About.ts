import { DatePipe } from '@angular/common';

export class About {
  constructor(
    public id?: number,
    public title?: string,
    public imageName?: string,
    public description?: string,
    public profile_desc?: string,
    public fullname?: string,
    public birth_date?: DatePipe,
    public job?: string,
    public website?: string,
    public email?: string,
    public skills_desc?: string) { }
}
