import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsFigadoComponent } from './us-figado.component';

describe('UsFigadoComponent', () => {
  let component: UsFigadoComponent;
  let fixture: ComponentFixture<UsFigadoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsFigadoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsFigadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
