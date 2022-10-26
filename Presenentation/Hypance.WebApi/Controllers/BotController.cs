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
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost]
        public IActionResult Post(Bot bot)
        {
            _botRepository.Add(bot);
            return Ok();
        }
        [HttpPut]
        public void Put()
        {
        }
        [HttpDelete]
        public void Delete()
        {
        }
    }
}
