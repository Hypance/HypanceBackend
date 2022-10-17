using Hypance.Core.Domain.Common;

namespace Hypance.Core.Domain.Strategies
{
    public class IndicatorSignal : BaseEntity
    {
        public string IndicatorName { get; set; }
        public string SymbolName { get; set; }
        public int Period { get; set; }
        public Interval Interval { get; set; }
        public int[] Signals { get; set; }
        public bool IsActive { get; set; }
    }
}