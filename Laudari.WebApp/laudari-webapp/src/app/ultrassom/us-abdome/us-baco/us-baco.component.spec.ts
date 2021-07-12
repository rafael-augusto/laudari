import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsBacoComponent } from './us-baco.component';

describe('UsBacoComponent', () => {
  let component: UsBacoComponent;
  let fixture: ComponentFixture<UsBacoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsBacoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsBacoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
