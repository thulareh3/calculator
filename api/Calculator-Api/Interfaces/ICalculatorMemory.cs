using Calculator_Api.Dtos;

namespace Calculator_Api.Interfaces
{
    public interface ICalculatorMemory
    {
        double AddToMemory(MemoryRequestDto dto);
        double SubtractFromMemory(MemoryRequestDto dto);
        double RecallMemory();
    }
}
