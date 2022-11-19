using Hypance.Core.Domain.Strategies;
using Hypance.Data;
using Microsoft.AspNetCore.Http;
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
        public IEnumerable<IndicatorSignal> GetAll()
        {
            var result = _indicatorSignalRepository.GetAll();

            return result.Data;
        }

        [HttpGet("{id}")]
        public IndicatorSignal Get(int id)
        {
            var model = _indicatorSignalRepository.Get(x => x.Id == id);

            return model.Data; 
        }

        [HttpPost]
        public IActionResult Post(IndicatorSignal indicatorSignal)
        {
            _indicatorSignalRepository.Add(indicatorSignal);

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(IndicatorSignal indicatorSignal)
        {
            _indicatorSignalRepository.Update(indicatorSignal);

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(IndicatorSignal indicatorSignal)
        {
            _indicatorSignalRepository.Delete(indicatorSignal);

            return Ok();
        }
    }
}