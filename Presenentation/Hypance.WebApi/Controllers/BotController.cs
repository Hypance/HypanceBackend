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

            return model;
        }
        
        [HttpGet("{id}")]
        public Bot Get(int id)
        {
            var model = _botRepository.Get(x => x.Id == id);

            return model;
        }

        [HttpPost]
        public IActionResult Post(Bot bot)
        {
            _botRepository.Add(bot);

            return Ok();
        }
       
        [HttpPut]
        public IActionResult Put(Bot bot)
        {
            _botRepository.Update(bot);

            return Ok();
        }
       
        [HttpDelete]
        public IActionResult Delete(Bot bot)
        {
            _botRepository.Delete(bot);

            return Ok();
        }
    }
}
