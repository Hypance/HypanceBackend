using Hypance.Core.Domain.Symbols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypance.Core.Dtos.Bots
{
    public class BotDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Interval { get; set; }
        public bool IsActive { get; set; }
        public decimal TotalProfit { get; set; }
        public List<Symbol> Symbols { get; set; }
        public List<string> StrategyTitles { get; set; }
    }
}
