using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hypance.Core.Domain.Backtests;
using Hypance.Core.Domain.Common;
using Hypance.Core.Domain.Formations;
using Hypance.Core.Domain.Strategies;
using Hypance.Core.Domain.Symbols;

namespace Hypance.Core.Domain.Notifications
{
    public class Notification : BaseEntity
    {
        public string Name {get; set; }
        public Market Market {get; set; }
        public OrderType OrderType {get; set; }
        public PositionType PositionType {get; set; }
        public TrendStrategy TrendStrategy { get; set; }
        public MessageChannel MessageChannel {get; set; }
        public ICollection<Symbol> Symbols { get; set; }
        public ICollection<Strategy> Strategy { get; set; }
        public ICollection<Formation> Formation { get; set; }
    }
}