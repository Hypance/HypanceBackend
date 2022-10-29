using Hypance.Core.Domain.Strategies;
using Hypance.Data;
using Microsoft.AspNetCore.Mvc;
using Hypance.Services.TelegramApi;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hypance.WebApi.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class StrategyController : Controller
    {
        private readonly IRepository<Strategy> _strategyRepository;

        public StrategyController(IRepository<Strategy> strategyRepository)
        {
            _strategyRepository = strategyRepository;
        }

        // GET: api/<StrategyController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            TelegramApiConfig.Main();
            
            return new string[] { "value1", "value2" };
        }

        // GET api/<StrategyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StrategyController>
        [HttpPost]
        public IActionResult Post(Strategy strategy)
        {
            _strategyRepository.Add(strategy);

            return Ok();
        }

        // PUT api/<StrategyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StrategyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
