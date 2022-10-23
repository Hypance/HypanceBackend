using Hypance.Core.Domain.Bots;
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
        public IEnumerable<Bot> GetAll()
        {
            return _botRepository.GetAll();
        }
    }
}
