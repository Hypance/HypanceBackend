using Hypance.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypance.Core.Domain.Formations
{
    public class FormationSignal : BaseEntity
    {
        public string IndicatorName { get; set; }
        public string SymbolName { get; set; }
        public int Period { get; set; }
        public Interval Interval { get; set; }
        public bool Result { get; set; }
        public bool IsActive { get; set; }
    }
}
