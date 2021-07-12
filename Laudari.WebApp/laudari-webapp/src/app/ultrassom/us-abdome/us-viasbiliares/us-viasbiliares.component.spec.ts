import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsViasbiliaresComponent } from './us-viasbiliares.component';

describe('UsViasbiliaresComponent', () => {
  let component: UsViasbiliaresComponent;
  let fixture: ComponentFixture<UsViasbiliaresComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsViasbiliaresComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsViasbiliaresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
