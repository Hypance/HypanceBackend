using Hypance.Core.Domain.Common;
using Hypance.Core.Domain.Formations;
using Hypance.Core.Domain.Strategies;
using Hypance.Core.Domain.Symbols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypance.Core.Domain.Bots
{
    public class Bot : BaseEntity
    {
        public string Name { get; set; }
        public List<Market> Markets { get; set; }
        public List<OrderType> OrderTypes { get; set; }
        public List<PositionType> PositionTypes { get; set; }
        public List<Symbol> Symbols { get; set; }
        public List<Strategy> Strategy { get; set; }
        public List<Formation> Formation { get; set; }
        public TrendStrategy TrendStrategies { get; set; }
        public decimal PriceVolume { get; set; }
    }
}