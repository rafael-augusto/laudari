import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsRinsUreteresComponent } from './us-rins-ureteres.component';

describe('UsRinsUreteresComponent', () => {
  let component: UsRinsUreteresComponent;
  let fixture: ComponentFixture<UsRinsUreteresComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsRinsUreteresComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsRinsUreteresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
