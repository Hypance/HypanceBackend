using Hypance.Core.Domain.Common;

namespace Hypance.Core.Domain.Strategies
{
   public class Signal : BaseEntity
   {
        public string Name { get; set; }
        public int Period { get; set; }
        public int IndicatorId { get; set; }
        public SignalResult SignalResult { get; set; }
        public Interval Interval { get; set; }
        public TrendStrategy TrendStrategy { get; set; }
    }
}