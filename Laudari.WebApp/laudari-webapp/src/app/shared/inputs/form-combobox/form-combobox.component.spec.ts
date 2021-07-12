import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormComboboxComponent } from './form-combobox.component';

describe('FormComboboxComponent', () => {
  let component: FormComboboxComponent;
  let fixture: ComponentFixture<FormComboboxComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormComboboxComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormComboboxComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
