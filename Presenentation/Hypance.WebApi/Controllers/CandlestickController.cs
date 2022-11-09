using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hypance.Core.Domain.Symbols;
using Hypance.Data;
using Microsoft.AspNetCore.Mvc;
using Hypance.Core.Domain.Common;


namespace Hypance.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CandlestickController
    {
        private readonly IRepository<Candlestick> _candlestickRepository;
        public CandlestickController(IRepository<Candlestick> candlestickRepository)
        {
            _candlestickRepository = candlestickRepository;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Candlestick> GetAll()
        {
            var result = _candlestickRepository.GetAll();
            return result.Data;
        }

        // PUT api/<CandlestickController>
        [HttpPut]
        public IActionResult Put(Candlestick candlestick)
        {
            _candlestickRepository.Update(candlestick);

            return Ok();
        }

        // POST api/<CandlestickController>
        [HttpPost]
        public IActionResult Post(Candlestick candlestick)
        {
            _candlestickRepository.Add(candlestick);

            return Ok();
        }

        // DELETE api/<CandlestickController>
        [HttpDelete]
        public IActionResult Delete(Candlestick candlestick)
        {
            _candlestickRepository.Delete(candlestick);

            return Ok();
        }
     
    }
}
