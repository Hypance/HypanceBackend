using Hypance.Core.Domain.Bots;
using Hypance.Core.Domain.Formations;
using Hypance.Core.Domain.Strategies;
using Hypance.Core.Domain.Symbols;
using Hypance.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hypance.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class FormationSignalController : Controller
    {
        private readonly IRepository<FormationSignal> _formationSignalrepository;
        public FormationSignalController(IRepository<FormationSignal> formationSignalRepository)
        {
            _formationSignalrepository = formationSignalRepository;
        }

        [HttpGet]
        public List<FormationSignal> GetAll()
        {
            var model = _formationSignalrepository.GetAll();

            return model.Data;
        }

        [HttpGet("{id}")]
        public FormationSignal Get(int id)
        {
            var model = _formationSignalrepository.Get(x => x.Id == id);
            if (model.Success)
                return model.Data;

            return new FormationSignal();
        }

        [HttpPost]
        public IActionResult Post(FormationSignal formationSignal)
        {
            var result = _formationSignalrepository.Add(formationSignal);
            if (result.Success)
                return Ok();

            return BadRequest();
        }

        [HttpPut]
        public IActionResult Put(FormationSignal formationSignal)
        {
            var result = _formationSignalrepository.Update(formationSignal);
            if (result.Success)
                return Ok();

            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete(FormationSignal formationSignal)
        {
            var result = _formationSignalrepository.Delete(formationSignal);
            if (result.Success)
                return Ok();

            return BadRequest();
        }
    }
}
