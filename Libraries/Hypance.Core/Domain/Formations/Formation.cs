using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hypance.Core.Domain.Common;
using Hypance.Core.Domain.Strategies;

namespace Hypance.Core.Domain.Formations
{
    public class Formation : BaseEntity
    {
        public string Name { get; set; }
        public List<Indicator> Indicators { get; set; }
        public List<SignalResult> SignalResults { get; set; }
        public int Period { get; set; }
        public Interval Interval { get; set; }
    }
}
