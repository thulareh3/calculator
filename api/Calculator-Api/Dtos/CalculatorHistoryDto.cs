namespace Calculator_Api.Dtos
{
    public class CalculatorHistoryDto
    {
        public required string Expression { get; set; }
        public double Result { get; set; }
        public DateTime TimesTamp { get; set; }
    }
}
