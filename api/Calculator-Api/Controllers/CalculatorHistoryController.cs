using Calculator_Api.Dtos;
using Calculator_Api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_Api.Controllers
{
    [Route("api/calchistory")]
    [ApiController]
    public class CalculatorHistoryController(ICalculatorHistory calculatorHistory) : ControllerBase
    {
        private readonly ICalculatorHistory _calculatorHistory = calculatorHistory;
        [HttpPost("add")]
        public IActionResult Add([FromBody] CalculatorHistoryDto dto)
        {
            ArgumentNullException.ThrowIfNull(dto);
            _calculatorHistory.Add(dto);
            return Ok(new {message = "History added"});
        }
        [HttpGet("history")]
        public IActionResult GetHistory()
        {
            return Ok(_calculatorHistory.GetAll());
        }
        [HttpDelete("history")]
        public IActionResult Clear()
        {
            _calculatorHistory.Clear();
            return Ok(new {message = "History cleared"});
        }

    }
}
