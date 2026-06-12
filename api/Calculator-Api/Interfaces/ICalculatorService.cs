using Calculator_Api.Dtos;

namespace Calculator_Api.Interfaces
{
    public interface ICalculatorService
    {
        double Add(CalcRequestDto dto);
        double Subtract(CalcRequestDto dto);
        double Multiply(CalcRequestDto dto);
        double Divide(CalcRequestDto dto);

    }
}
