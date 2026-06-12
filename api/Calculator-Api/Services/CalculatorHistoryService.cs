using Calculator_Api.Dtos;
using Calculator_Api.Interfaces;

namespace Calculator_Api.Services
{
    public class CalculatorHistoryService : ICalculatorHistory
    {
        private List<CalculatorHistoryDto> _history = [];
        public void Add(CalculatorHistoryDto dto)
        {
            _history.Add(new CalculatorHistoryDto
            {
                Expression = dto.Expression,
                Result = dto.Result,
                TimesTamp = DateTime.UtcNow
            });

        }

        public void Clear()
        {
            _history?.Clear();
        }

        public List<CalculatorHistoryDto> GetAll()
        {
            return _history;
        }
    }
}
