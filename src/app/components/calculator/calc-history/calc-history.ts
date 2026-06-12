import { Component, Inject } from '@angular/core';
import { MAT_BOTTOM_SHEET_DATA } from '@angular/material/bottom-sheet';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-calc-history',
  imports: [CommonModule],
  templateUrl: './calc-history.html',
  styleUrl: './calc-history.css',
})
export class CalcHistory {

  constructor(@Inject(MAT_BOTTOM_SHEET_DATA) public data:any[]){}

}
