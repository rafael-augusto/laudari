import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LimitacoesTecnicasComponent } from './limitacoes-tecnicas.component';

describe('LimitacoesTecnicasComponent', () => {
  let component: LimitacoesTecnicasComponent;
  let fixture: ComponentFixture<LimitacoesTecnicasComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LimitacoesTecnicasComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LimitacoesTecnicasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
