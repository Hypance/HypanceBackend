namespace Hypance.Core.Domain.Strategies
{
   public class Signal
   {
    public string Name { get; set; }
    public List<Indicator> Indicators { get; set; }
    public List<SignalResult> SignalResults { get; set; }
    public int Period { get; set; }
    public enum Interval { get; set; }
   }
}