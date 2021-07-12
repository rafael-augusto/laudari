import { UltrassomModule } from './ultrassom.module';

describe('UltrassomModule', () => {
  let ultrassomModule: UltrassomModule;

  beforeEach(() => {
    ultrassomModule = new UltrassomModule();
  });

  it('should create an instance', () => {
    expect(ultrassomModule).toBeTruthy();
  });
});
