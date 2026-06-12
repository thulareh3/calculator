export class HistoryModel {
    constructor(
        public expression: string = '',
        public result: number = 0.0,
        public timeStamp: Date 
    ){}

}