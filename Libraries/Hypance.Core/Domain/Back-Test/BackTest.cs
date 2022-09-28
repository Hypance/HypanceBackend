using System;
namespace Hypance.Core.Domain.Back_Test
{
    public class CreateBackTest
    {
        public string BackTestName { get; set; }
        public List<PredefinedMarket> PredefinedMarket { get; set; }
        public List<PriceStrategy> PriceStrategy { get; set; }
        public List<BotType> BotType { get; set; }
        public List<PredefinedAssets> PredefinedAssets { get; set; }
        public List<PredefinedStrategy> PredefinedStrategy { get; set; }
        public List<Formation> Formation { get; set; }
        public string TrendStrategy { get; set; }
    }
}
