import { TestBed } from '@angular/core/testing';

import { CalculatorMemoryService } from './calculator-memory-service';

describe('CalculatorMemoryService', () => {
  let service: CalculatorMemoryService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CalculatorMemoryService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
