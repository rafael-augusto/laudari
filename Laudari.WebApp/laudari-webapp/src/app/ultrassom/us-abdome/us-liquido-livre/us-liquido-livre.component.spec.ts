import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsLiquidoLivreComponent } from './us-liquido-livre.component';

describe('UsLiquidoLivreComponent', () => {
  let component: UsLiquidoLivreComponent;
  let fixture: ComponentFixture<UsLiquidoLivreComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsLiquidoLivreComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsLiquidoLivreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
