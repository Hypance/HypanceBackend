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
        public List<PredefinedStrategy> PredefinedStrategy { get; set; }
        public List<Formation> Formation { get; set; }
        public string TrendStrategy { get; set; }
    }
}
