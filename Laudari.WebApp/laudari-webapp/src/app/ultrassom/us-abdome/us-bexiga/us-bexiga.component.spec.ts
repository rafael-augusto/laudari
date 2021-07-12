import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsBexigaComponent } from './us-bexiga.component';

describe('UsBexigaComponent', () => {
  let component: UsBexigaComponent;
  let fixture: ComponentFixture<UsBexigaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsBexigaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsBexigaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
