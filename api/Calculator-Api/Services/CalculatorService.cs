using Calculator_Api.Dtos;
using Calculator_Api.Interfaces;

namespace Calculator_Api.Services
{
    public class CalculatorService : ICalculatorService
    {
        public double Add(CalcRequestDto dto)
        {
            return dto.A + dto.B; 
        }

        public double Divide(CalcRequestDto dto)
        {
            if (dto.B == 0)
            {
                return 0;
            }
            else
            {
                return dto.A / dto.B;
            }
        }

        public double Multiply(CalcRequestDto dto)
        {
            return (dto.A * dto.B);
        }

        public double Subtract(CalcRequestDto dto)
        {
            return dto.A - dto.B;
        }
    }
}
