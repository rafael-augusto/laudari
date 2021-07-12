import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormTextAddonComponent } from './form-text-addon.component';

describe('FormTextAddonComponent', () => {
  let component: FormTextAddonComponent;
  let fixture: ComponentFixture<FormTextAddonComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormTextAddonComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormTextAddonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
