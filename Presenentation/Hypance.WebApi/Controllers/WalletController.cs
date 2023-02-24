using System;
using Hypance.Core.Domain.Wallet;
using Hypance.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Hypance.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WalletController : Controller
    {
        private readonly IRepository<Wallet> _walletRepository;

        public WalletController(IRepository<Wallet> walletRepository)
        {
            _walletRepository = walletRepository;
        }

        [HttpGet]
        public List<Wallet> GetAll()
        {
            var model = _walletRepository.GetAll();
            return model.Data;
        }

        [HttpGet("{id}")]
        public Wallet Get(int id)
        {
            var model = _walletRepository.Get(x => x.Id == id);
            if (model.Success)
                return model.Data;
            return new Wallet();
        }

        [HttpPost]
        public IActionResult Post(Wallet wallet)
        {
            var result = _walletRepository.Add(wallet);
            if (result.Success)
                return Ok();
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Put(Wallet wallet)
        {
            var result = _walletRepository.Update(wallet);
            if (result.Success)
                return Ok();
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete(Wallet wallet)
        {
            var result = _walletRepository.Delete(wallet);
            if (result.Success)
                return Ok();
            return BadRequest();
        }
    }
}