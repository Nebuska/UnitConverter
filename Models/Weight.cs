namespace Models;

public class Weight(double value, Weight.Units unit)
{
    public enum Units
    {
        Milligram,
        Gram,
        Kilogram,
        MetricTon,
        Ounce,
        Pound
    }
    
    private const double MilligramMultiplier = 1;
    private const double GramMultiplier = 1000 * MilligramMultiplier;
    private const double KilogramMultiplier = 1000 * GramMultiplier;
    private const double MetricTonMultiplier = 1000 * KilogramMultiplier;
    private const double OunceMultiplier = 28.3495 * GramMultiplier;
    private const double PoundMultiplier = 16 * OunceMultiplier;

    private double Value { get; set; } = value;

    private Units Unit { get; set; } = unit;

    public double ConvertTo(Units unit)
    {
        Value = Value * (GetMultiplier(Unit) / GetMultiplier(unit));
        Unit = unit;
        return Value;
    }
    
    public static double Convert(double value, Units from, Units to)
    {
        return value * (GetMultiplier(to) / GetMultiplier(from));
    }
    
    private static double GetMultiplier(Units unit)
    {
        return unit switch
        {
            Units.Milligram => MilligramMultiplier,
            Units.Gram => GramMultiplier,
            Units.Kilogram => KilogramMultiplier,
            Units.MetricTon => MetricTonMultiplier,
            Units.Ounce => OunceMultiplier,
            Units.Pound => PoundMultiplier,
            _ => throw new ArgumentOutOfRangeException(nameof(unit), unit, null)
        };
    }
}