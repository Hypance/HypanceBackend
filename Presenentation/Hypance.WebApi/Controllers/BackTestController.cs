using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hypance.Core.Domain.Backtests;
using Hypance.Core.Domain.Strategies;
using Hypance.Data;
using Microsoft.AspNetCore.Mvc;


namespace Hypance.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BackTestController : Controller
    {
        private readonly IRepository<Backtest> _backtestRepository;

        public BackTestController(IRepository<Backtest> backtestRepository)
        {
            _backtestRepository = backtestRepository;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Backtest> GetAll()
        {
            return _backtestRepository.GetAll();
        }

        // PUT api/<BacktestController>
        [HttpPut]
        public IActionResult Put(Backtest backtest)
        {
            _backtestRepository.Update(backtest);

            return Ok();
        }

        // POST api/<BacktestController>
        [HttpPost]
        public IActionResult Post(Backtest backtest)
        {
            _backtestRepository.Add(backtest);

            return Ok();
        }

        // DELETE api/<BacktestController>
        [HttpDelete]
        public IActionResult Delete(Backtest backtest)
        {
            _backtestRepository.Delete(backtest);

            return Ok();
        }


    }
}