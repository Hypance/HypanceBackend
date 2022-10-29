using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hypance.Core.Domain.Strategies;
using Hypance.Core.Domain.Symbols;
using Hypance.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hypance.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SymbolController : Controller
    {
        private readonly IRepository<Symbol> _symbolRepository;

        public SymbolController(IRepository<Symbol> symbolRepository)
        {
            _symbolRepository = symbolRepository;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Symbol> GetAll()
        {
            var result = _symbolRepository.GetAll();
            return result.Data;
        }

        
    }
}

