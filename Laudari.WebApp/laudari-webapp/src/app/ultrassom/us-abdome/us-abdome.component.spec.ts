import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsAbdomeComponent } from './us-abdome.component';

describe('UsAbdomeComponent', () => {
  let component: UsAbdomeComponent;
  let fixture: ComponentFixture<UsAbdomeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsAbdomeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsAbdomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
