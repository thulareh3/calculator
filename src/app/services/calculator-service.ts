import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';

interface CalcRequest {
  a: number;
  b: number;
}
interface CalcResponse {
  result: number;
}

@Injectable({
  providedIn: 'root',
})
export class CalculatorService {

  private baseUrl: string = 'http://localhost:5004/api/calculator';

  constructor(private http: HttpClient) { }

  add(request: CalcRequest): Observable<number> {
    return this.http.post<CalcResponse>(
      `${this.baseUrl}/add`,
      request
    ).pipe(map(res => res.result))
  }

  subtract(request: CalcRequest): Observable<number> {
    return this.http.post<CalcResponse>(
      `${this.baseUrl}/subtract`,
      request
    ).pipe(map(res => res.result))
  }

  multiply(request: CalcRequest): Observable<number> {
    return this.http.post<CalcResponse>(
      `${this.baseUrl}/multiply`,
      request
    ).pipe(map(res => res.result))
  }

  divide(request: CalcRequest): Observable<number> {
    return this.http.post<CalcResponse>(
      `${this.baseUrl}/divide`,
      request
    ).pipe(map(res => res.result))
  }
}
