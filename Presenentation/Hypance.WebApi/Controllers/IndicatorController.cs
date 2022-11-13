using Hypance.Core.Domain.Bots;
using Hypance.Core.Domain.Strategies;
using Hypance.Core.Domain.Symbols;
using Hypance.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace Hypance.WebApi.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class IndicatorController : Controller
    {
        private readonly IRepository<Indicator> _indicatorRepository;

        public IndicatorController(IRepository<Indicator> indicatorRepository)
        {
            _indicatorRepository = indicatorRepository;
        }

      
        [HttpGet]
        public List<Indicator> GetAll()
        {
            var model = _indicatorRepository.GetAll();
            return model.Data;
        }

    
        [HttpGet("{id}")]
        public Indicator Get(int id)
        {
            var model = _indicatorRepository.Get(x => x.Id == id);
            if (model.Success)
                return model.Data;
            return new Indicator();
        }

     
        [HttpPost]
        public IActionResult Post(Indicator indicator)
        {
            var result = _indicatorRepository.Update(indicator);
            if (result.Success)
                return Ok();

            return BadRequest();
        }

      
        [HttpPut]
        public IActionResult Put(Indicator indicator)
        {
            var result = _indicatorRepository.Update(indicator);
            if (result.Success)
                return Ok();

            return BadRequest();
        }

      
        [HttpDelete]
        public IActionResult Delete(Indicator indicator)
        {
            var result = _indicatorRepository.Delete(indicator);
            if (result.Success)
                return Ok();

            return BadRequest();
        }
    }
}