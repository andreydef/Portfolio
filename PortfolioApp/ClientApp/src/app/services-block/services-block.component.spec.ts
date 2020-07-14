import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ServicesBlockComponent } from './services-block.component';

describe('ServicesBlockComponent', () => {
  let component: ServicesBlockComponent;
  let fixture: ComponentFixture<ServicesBlockComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ServicesBlockComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ServicesBlockComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
