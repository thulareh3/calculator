using Calculator_Api.Dtos;

namespace Calculator_Api.Interfaces
{
    public interface ICalculatorHistory
    {
        void Add(CalculatorHistoryDto dto);
        List<CalculatorHistoryDto> GetAll();
        void Clear();
    }
}
