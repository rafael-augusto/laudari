import { TestBed, inject } from '@angular/core/testing';

import { UsAbdomeService } from './us-abdome.service';

describe('UsAbdomeService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [UsAbdomeService]
    });
  });

  it('should be created', inject([UsAbdomeService], (service: UsAbdomeService) => {
    expect(service).toBeTruthy();
  }));
});
