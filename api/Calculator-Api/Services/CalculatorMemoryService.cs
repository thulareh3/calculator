using Calculator_Api.Dtos;
using Calculator_Api.Interfaces;

namespace Calculator_Api.Services
{
    
    public class CalculatorMemoryService : ICalculatorMemory
    {
        private double _memory = 0;
        public double AddToMemory(MemoryRequestDto dto)
        {
            _memory += dto.Value;
            return _memory;
        }

        public double RecallMemory()
        {
            return _memory;
        }

        public double SubtractFromMemory(MemoryRequestDto dto)
        {
            _memory -= dto.Value;
            return _memory;
        }
    }
}
