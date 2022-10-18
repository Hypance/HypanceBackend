using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypance.Core.Domain.Strategies
{
    public class Indicator : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultPeriod { get; set; }
        public bool IsActive { get; set; }
    }
}