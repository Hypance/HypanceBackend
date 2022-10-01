using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypance.Core.Domain.Strategy
{
   public class Signal
   {
    public string SignalName { get; set; }
    public List<Indicator> Indicators { get; set; }
    public List<Setting> Settings { get; set; }
    public int Period { get; set; }
    public enum Interval { get; set; }
   }
}