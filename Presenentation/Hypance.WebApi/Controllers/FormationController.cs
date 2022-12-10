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
            
            if(model.Success)
              return model.Data;

            return new Formation();
        }
      
        [HttpPost]
        public IActionResult Post(Formation formation)
        {
            var result = _formationRepository.Add(formation);
            if(result.Success)
                return Ok();

            return BadRequest();
        }

        [HttpPut]
        public IActionResult Put(Formation formation)
        {
            var result = _formationRepository.Update(formation);
            
            if(result.Success)
                return Ok();

            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete(Formation formation)
        {
            var result = _formationRepository.Delete(formation);
            if(result.Success)
                return Ok();

            return BadRequest();
        }
    }
}
