using Calculator_Api.Dtos;
using Calculator_Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController(ICalculatorService calculatorService) : ControllerBase
    {
        private readonly ICalculatorService _calculatorService = calculatorService;

        [HttpPost("add")]
        public IActionResult Add([FromBody] CalcRequestDto dto)
        {
            return Ok(new CalcResponseDto {
                Result = _calculatorService.Add(dto) 
            });

        }
        [HttpPost("subtract")]
        public IActionResult Subtract([FromBody] CalcRequestDto dto)
        {
            return Ok(
                new CalcResponseDto {
                    Result = _calculatorService.Subtract(dto)
                });

        }
        [HttpPost("divide")]
        public IActionResult Divide([FromBody] CalcRequestDto dto)
        {
            return Ok( new CalcResponseDto
            {
                Result = _calculatorService.Divide(dto)
            });

        }
        [HttpPost("multiply")]
        public IActionResult Multiply([FromBody] CalcRequestDto dto)
        {
            return Ok(new CalcResponseDto {
                Result = _calculatorService.Multiply(dto) 
            });

        }
    }
}
