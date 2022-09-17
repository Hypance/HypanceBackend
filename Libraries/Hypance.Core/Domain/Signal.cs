using System;

public class Signal
{
    public string SignalName { get; set; }
    public List<Indicator> Indıcators { get; set; }
    public List<Setting> Settings { get; set; }
    public int Period { get; set; }
    public enum Interval { get; set; }
}