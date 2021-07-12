import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsVolumeVesicalComponent } from './us-volume-vesical.component';

describe('UsVolumeVesicalComponent', () => {
  let component: UsVolumeVesicalComponent;
  let fixture: ComponentFixture<UsVolumeVesicalComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsVolumeVesicalComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsVolumeVesicalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
