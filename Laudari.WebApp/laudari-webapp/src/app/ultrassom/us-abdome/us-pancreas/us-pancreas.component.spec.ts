import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsPancreasComponent } from './us-pancreas.component';

describe('UsPancreasComponent', () => {
  let component: UsPancreasComponent;
  let fixture: ComponentFixture<UsPancreasComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsPancreasComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsPancreasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
