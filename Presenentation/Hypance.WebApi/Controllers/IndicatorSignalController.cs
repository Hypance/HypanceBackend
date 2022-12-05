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
        public List<IndicatorSignal> GetAll()
        {
            var result = _indicatorSignalRepository.GetAll();

            return result.Data;
        }

        [HttpGet("{id}")]
        public IndicatorSignal Get(int id)
        {
            var model = _indicatorSignalRepository.Get(x => x.Id == id);
            if (model.Success)
                return model.Data; 

            return new IndicatorSignal();
        }

        [HttpPost]
        public IActionResult Post(IndicatorSignal indicatorSignal)
        {
            var result = _indicatorSignalRepository.Add(indicatorSignal);
            if (result.Success)
                return Ok();

            return BadRequest();
        }

        [HttpPut]
        public IActionResult Put(IndicatorSignal indicatorSignal)
        {
            var result = _indicatorSignalRepository.Update(indicatorSignal);
            if (result.Success)
                return Ok();

            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete(IndicatorSignal indicatorSignal)
        {
            var result = _indicatorSignalRepository.Delete(indicatorSignal);
            if (result.Success)
                return Ok();

            return BadRequest();
        }
    }
}