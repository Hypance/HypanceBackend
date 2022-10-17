using Hypance.Core.Domain.Common;
using Hypance.Core.Domain.Formations;
using Hypance.Core.Domain.Strategies;
using Hypance.Core.Domain.Symbols;

namespace Hypance.Core.Domain.Backtests
{
    public class Backtest : BaseEntity
    {
        public string Name { get; set; }
        public List<Market> Market { get; set; }
        public List<OrderType> OrderTypes { get; set; }
        public List<PositionType> Positiontypes { get; set; }
        public List<Symbol> Symbols { get; set; }
        public List<Strategy> Strategy { get; set; }
        public List<Formation> Formation { get; set; }
        public TrendStrategy TrendStrategy { get; set; }
    }
}
