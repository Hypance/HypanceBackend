using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hypance.Core.Domain.Notification
{
    public class CreateNotification
    {
        public string Name {get; set; }
        public List<PredifinedMarket> PredifinedMarket {get; set; }
        public List<PriceStrategy> PriceStrategy {get; set; }
        public List<NotificationType> NotificationType {get; set; }
        public List<PredefinedAssets> PredefinedAssets { get; set; }
        public List<PredefinedStrategy> PredefinedStrategy { get; set; }
        public List<Formation> Formation {get; set; }
        public string TrendStrategy {get; set; }
        public List<MessageChanel> MessageChanel {get; set; }   
    }
}