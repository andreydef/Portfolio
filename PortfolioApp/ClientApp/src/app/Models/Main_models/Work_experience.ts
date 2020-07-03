import { DatePipe } from '@angular/common';

export class WorkExperience {
  constructor(
    public id?: number,
    public name_job?: string,
    public date_start?: DatePipe,
    public date_finish?: DatePipe,
    public title_job?: string,
    public description?: string) {}
}
