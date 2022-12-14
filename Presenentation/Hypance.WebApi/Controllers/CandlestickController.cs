using Hypance.Core.Domain.Symbols;
using Hypance.Data;
using Microsoft.AspNetCore.Mvc;


namespace Hypance.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CandlestickController : Controller
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
            var result = _candlestickRepository.Update(candlestick);
            if (result.Success)
                return Ok();

            return BadRequest();

        }

        // POST api/<CandlestickController>
        [HttpPost]
        public IActionResult Post(Candlestick candlestick)
        {
            var result = _candlestickRepository.Add(candlestick);
            if (result.Success)
                return Ok();

            return BadRequest();
        }

        // DELETE api/<CandlestickController>
        [HttpDelete]
        public IActionResult Delete(Candlestick candlestick)
        {
            var result = _candlestickRepository.Delete(candlestick);
            if (result.Success)
                return Ok();

            return BadRequest();
        }
     
    }
}
