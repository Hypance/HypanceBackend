using System;
using Hypance.Core.Domain.Common;

namespace Hypance.Core.Domain.Symbols
{
	public class Candlestick :  BaseEntity
	{
		public string Name { get; set; }
		public DateTime OpenTime { get; set; }
		public decimal OpenPrice { get; set; }
        public decimal HighPrice { get; set; }
        public decimal LowPrice { get; set; }
        public decimal ClosePrice { get; set; }
        public decimal Volume { get; set; }
        public DateTime CloseTime { get; set; }
        public Interval Interval { get; set; }
        public string Symbol { get; set; }
        public bool IsActive { get; set; }
    }
}

