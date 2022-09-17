using System;
public class Strategy
{


    public string StrategyName { get; set; }
    public List<Signal> Signal { get; set; }

}

public class Indıcator
{
    public string IndıcatorName { get; set; }
}
public class Setting
{
    public string SettingName { get; set; }

}
public enum Interval
{
    T_1m = 1,
    T_5m,
    T_15m,
    T_30m,
    T_1h,
    T_4h,
    T_8h,
    T_1d,
}
public class MyStrategies
{
    public List<PageType> PageTypes { get; set; }
    public string DesignExample { get; set; }
}
