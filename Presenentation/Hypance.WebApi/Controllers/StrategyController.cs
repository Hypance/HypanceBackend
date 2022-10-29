using Hypance.Core.Domain.Strategies;
using Hypance.Data;
using Microsoft.AspNetCore.Mvc;

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
        public List<Strategy> GetAll()
        {
            var model = _strategyRepository.GetAll(); 
            return model.Data;
        }

        // GET api/<StrategyController>/5
        [HttpGet("{id}")]
        public Strategy Get(int id)
        {
            var model = _strategyRepository.Get(x => x.Id == id);
            return model.Data;
        }

        // POST api/<StrategyController>
        [HttpPost]
        public IActionResult Post(Strategy strategy)
        {
            _strategyRepository.Add(strategy);

            return Ok();
        }

        // PUT api/<StrategyController>/5
        [HttpPut]
        public IActionResult Put(Strategy strategy)
        {
            _strategyRepository.Update(strategy);
            return Ok();
        }

        // DELETE api/<StrategyController>/5
        [HttpDelete]
        public IActionResult Delete(Strategy strategy)
        {
           _strategyRepository.Delete(strategy);
           return Ok();
        }
    }
}
