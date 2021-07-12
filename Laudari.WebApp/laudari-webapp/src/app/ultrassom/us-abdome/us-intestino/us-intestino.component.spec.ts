import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsIntestinoComponent } from './us-intestino.component';

describe('UsIntestinoComponent', () => {
  let component: UsIntestinoComponent;
  let fixture: ComponentFixture<UsIntestinoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsIntestinoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsIntestinoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
