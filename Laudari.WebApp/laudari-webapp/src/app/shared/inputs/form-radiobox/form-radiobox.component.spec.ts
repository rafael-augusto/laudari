import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormRadioboxComponent } from './form-radiobox.component';

describe('FormRadioboxComponent', () => {
  let component: FormRadioboxComponent;
  let fixture: ComponentFixture<FormRadioboxComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormRadioboxComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormRadioboxComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
