import { TestBed } from '@angular/core/testing';

import { CalculatorHistoryService } from './calculator-history-service';

describe('CalculatorHistoryService', () => {
  let service: CalculatorHistoryService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CalculatorHistoryService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
