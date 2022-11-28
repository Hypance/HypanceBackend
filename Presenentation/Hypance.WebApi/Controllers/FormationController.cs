using Hypance.Core.Domain.Formations;
using Hypance.Data;
using Microsoft.AspNetCore.Mvc;
using Hypance.Services.TelegramApi;



namespace Hypance.WebApi.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class FormationController : Controller
    {
        private readonly IRepository<Formation> _formationRepository;

        public FormationController(IRepository<Formation> formationRepository)
        {
            _formationRepository = formationRepository;
        }
        [HttpGet]
        public List<Formation> GetAll()
        {
            var model = _formationRepository.GetAll();
            return model.Data;
        }

        [HttpGet("{id}")]
        public Formation Get(int id)
        {
            var model = _formationRepository.Get(x => x.Id == id);
            return model.Data;
        }
      
        [HttpPost]
        public IActionResult Post(Formation formation)
        {
            _formationRepository.Add(formation);

            return Ok();
        }
     
        [HttpPut]
        public IActionResult Put(Formation formation)
        {
            _formationRepository.Update(formation);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Formation formation)
        {
            _formationRepository.Delete(formation);
            return Ok();
        }
    }
}
