using Hypance.Core.Domain.Strategies;
using Hypance.Data;
using Microsoft.AspNetCore.Mvc;
using Hypance.Services.TelegramApi;



namespace Presentation.Hypance.WebApi.Controllers.IndicatorControllers
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
            return model.Data;
        }

     
        [HttpPost]
        public IActionResult Post(Indicator indicator)
        {
            _indicatorRepository.Add(indicator);

            return Ok();
        }

      
        [HttpPut]
        public IActionResult Put(Indicator indicator)
        {
            _indicatorRepository.Update(indicator);
            return Ok();
        }

      
        [HttpDelete]
        public IActionResult Delete(Indicator indicator)
        {
            _indicatorRepository.Delete(indicator);
            return Ok();
        }
    }
}