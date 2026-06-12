import { ChangeDetectionStrategy, ChangeDetectorRef, Component, OnDestroy } from '@angular/core';
import { MatCardModule, MatCard } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { N } from '@angular/cdk/keycodes';

import { CalculatorService } from '../../services/calculator-service';
import { Subject } from 'rxjs';
import { HistoryModel } from '../../models/calcHistoryModel';
import { Expression } from '@angular/compiler';
import { CalculatorHistoryService } from '../../services/calculator-history-service';
import { CalculationHistoryItem } from '../../interfaces/CalculationHistoryItem';

@Component({
  selector: 'app-calculator',
  imports: [MatCard, MatCardModule, MatButtonModule, MatInputModule, MatFormFieldModule],
  templateUrl: './calculator.html',
  styleUrl: './calculator.css',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class Calculator implements OnDestroy {

  display: string = '';
  memory: number = 0;
  history: any = [];
  private destroy$ = new Subject<void>();
  isResult: any = false;

  constructor(private calcService: CalculatorService, private cdr: ChangeDetectorRef, private calcHistoryService: CalculatorHistoryService) { }

  append(value: string): void {
    this.display += value;
  }
  clear(): void {
    this.display = '';
  }
  backspace(): void {
    this.display = this.display.slice(0, -1);
  }
  calculate(): void {
    const { a, b, operator } = this.passExpression(this.display);
    let results$;
    switch (operator) {
      case '+':
        results$ = this.calcService.add({ a, b });
        break;
      case '-':
        results$ = this.calcService.subtract({ a, b });
        break;
      case '/':
        results$ = this.calcService.divide({ a, b });
        break;
      case '*':
        results$ = this.calcService.multiply({ a, b });
        break;
      default:
        return;
    }

    console.log(this.display);
    results$.subscribe(res => {
      this.display = res.toString();
      let historyModel = new HistoryModel("", 0.0, new Date());
      historyModel.expression = `${a}${operator}${b} = ${this.display}`,
        historyModel.result = Number(this.display);
      this.calcHistoryService.AddHistory(historyModel).subscribe(res => console.log(res));
      this.cdr.markForCheck();
    })
  }
  memoryAdd(): void {
    const value = Number(this.display) || 0;
    this.memory += value;
  }
  memorySubtract(): void {
    const value = Number(this.display) || 0;
    this.memory -= value;
  }
  memoryRecall(): void {
    this.display = this.memory.toString();
  }
  showHistory(): void {
    this.calcHistoryService.getHistory().subscribe((res: any) => {
      this.history = res;
    })
    this.cdr.markForCheck();
  }
  private passExpression(expression: string): { a: number, b: number, operator: string } {

    const operators = ['+', '-', '*', '/'];
    for (const op of operators) {
      if (expression.includes(op)) {
        const [left, right] = expression.split(op);

        return {
          a: Number(left),
          b: Number(right),
          operator: op
        };
      }

    }
    throw new Error('Invalid expression');
  }

  ngOnDestroy(): void {
    this.destroy$.next();
    this.destroy$.complete();
  }

}
