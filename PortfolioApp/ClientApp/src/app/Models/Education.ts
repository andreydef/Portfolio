import { DatePipe } from '@angular/common';

export class Education {
  constructor(
    public id?: number,
    public name_education?: string,
    public date_start?: DatePipe,
    public date_finish?: DatePipe,
    public title_place?: string,
    public description?: string) {}
}
