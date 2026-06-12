import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { CalculationHistoryItem } from '../interfaces/CalculationHistoryItem';
import { HistoryModel } from '../models/calcHistoryModel';

@Injectable({
  providedIn: 'root',
})

export class CalculatorHistoryService {

  private baseUrl = 'http://localhost:5004/api/calchistory';

  constructor(private http: HttpClient) { }
  AddHistory(historyItem: HistoryModel): Observable<object> {
    return this.http.post(`${this.baseUrl}/add`, historyItem);
  }
  getHistory(): Observable<CalculationHistoryItem[]> {
    return this.http.get<CalculationHistoryItem[]>(
      `${this.baseUrl}/history`
    )
  }
  clearHistory(): Observable<object> {
    return this.http.delete(`${this.baseUrl}/history`)
  }

}
