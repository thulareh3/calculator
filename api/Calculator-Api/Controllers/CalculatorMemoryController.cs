using Calculator_Api.Dtos;
using Calculator_Api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorMemoryController(ICalculatorMemory calculatorMemory) : ControllerBase
    {
        private readonly ICalculatorMemory _calculatorMemory = calculatorMemory;

        [HttpPost("mplus")]
        public IActionResult AddToMemory([FromBody] MemoryRequestDto dto)
        {
            return Ok(_calculatorMemory.AddToMemory(dto));
        }

        [HttpPost("mminus")]
        public IActionResult SubtractFromMemory([FromBody] MemoryRequestDto dto)
        {
            return Ok(_calculatorMemory?.SubtractFromMemory(dto));
        }
        [HttpGet("mrecall")]
        public IActionResult recallMemory()
        {
            return Ok(_calculatorMemory.RecallMemory());
        }

    }
}
