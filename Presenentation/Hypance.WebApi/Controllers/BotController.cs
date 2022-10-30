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
    public class BotController : Controller
    {
        private readonly IRepository<Bot> _botRepository;
        public BotController(IRepository<Bot> botRepository)
        {
            _botRepository = botRepository;
        }
        
        [HttpGet]
        public List<Bot> GetAll()
        {
            var model = _botRepository.GetAll();

            return model.Data;
        }
        
        [HttpGet("{id}")]
        public Bot Get(int id)
        {
            var model = _botRepository.Get(x => x.Id == id);
            if (model.Success)
                return model.Data;

            return new Bot();
        }

        [HttpPost]
        public IActionResult Post(Bot bot)
        {
            var result = _botRepository.Add(bot);
            if (result.Success)
                return Ok();

            return BadRequest();
        }
       
        [HttpPut]
        public IActionResult Put(Bot bot)
        {
            var result = _botRepository.Update(bot);
            if (result.Success)
                return Ok();

            return BadRequest();
        }
       
        [HttpDelete]
        public IActionResult Delete(Bot bot)
        {
            var result = _botRepository.Delete(bot);
            if (result.Success)
                return Ok();

            return BadRequest();
        }
    }
}
