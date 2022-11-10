using Hypance.Core.Domain.Bots;
using Hypance.Core.Domain.Symbols;
using Hypance.Core.Dtos.Bots;
using Hypance.Core.Utilites;
using Hypance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypance.Services.Bots
{
    public class BotService : IBotService
    {
        private readonly IRepository<Bot> _botRepository;
        private readonly IRepository<Symbol> _symbolRepository;

        public BotService(
            IRepository<Bot> botRepository, IRepository<Symbol> symbolRepository)
        {
            _botRepository = botRepository;
            _symbolRepository = symbolRepository;
        }
        public IResult GetAllBots()
        {
            IResult result = new Result(false, "");
            try
            {
                List<BotDto> botDtos = new List<BotDto>();
                var bots = _botRepository.GetAll();
                if (bots.Success)
                {
                    var data = bots.Data.Select(s => 
                    {
                        var symbols = _symbolRepository.GetAll(b => s.AssetIds.Contains(b.Id));
                        return new BotDto()
                        {
                            Name = s.Name,
                            Description = s.Description,
                            Symbols = symbols.Success ? symbols.Data : new List<Symbol>()
                        };
                    }
                    ).ToList();

                    result = new SuccessDataResult<List<BotDto>>(data);
                }
            }

            catch (Exception ex)
            {
                result = new ErrorResult(ex.Message);
            }
            return result;
        }
    }
}
