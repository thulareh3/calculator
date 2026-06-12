import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CalcHistory } from './calc-history';

describe('CalcHistory', () => {
  let component: CalcHistory;
  let fixture: ComponentFixture<CalcHistory>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CalcHistory]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CalcHistory);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
