using Hypance.Core.Domain.Strategies;
using Hypance.Data;
using Microsoft.AspNetCore.Mvc;

namespace Hypance.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class IndicatorSignalController : Controller
    {
        private readonly IRepository<IndicatorSignal> _indicatorSignalRepository;

        public IndicatorSignalController(IRepository<IndicatorSignal> indicatorSignalRepository)
        {
            _indicatorSignalRepository = indicatorSignalRepository;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public IActionResult Post(IndicatorSignal indicatorSignal)
        {
            _indicatorSignalRepository.Add(indicatorSignal);

            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}