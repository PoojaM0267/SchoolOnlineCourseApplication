import { CoureseModule } from './courese.module';

describe('CoureseModule', () => {
  let coureseModule: CoureseModule;

  beforeEach(() => {
    coureseModule = new CoureseModule();
  });

  it('should create an instance', () => {
    expect(coureseModule).toBeTruthy();
  });
});
