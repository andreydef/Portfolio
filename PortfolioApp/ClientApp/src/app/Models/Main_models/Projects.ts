import { DatePipe } from '@angular/common';

export class Projects {
  constructor(
    public id?: number,
    public title?: string,
    public description?: string,
    public name_project?: string,
    public date_project?: DatePipe,
    public imageName?: string) {}
}
