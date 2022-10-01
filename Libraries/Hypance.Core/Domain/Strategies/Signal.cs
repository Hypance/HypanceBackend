using Hypance.Core.Domain.Common;

namespace Hypance.Core.Domain.Strategies
{
   public class Signal : BaseEntity
   {
        public string Name { get; set; }
        public List<Indicator> Indicators { get; set; }
        public List<SignalResult> SignalResults { get; set; }
        public int Period { get; set; }
        public Interval Interval { get; set; }
   }
}