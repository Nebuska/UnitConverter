using System.Text.Json.Serialization;

namespace Models;

public class Weight(double value, Weight.WeightUnits unit)
{
    public Weight() : this(0, default)
    {}
    
    [JsonConverter(typeof(JsonStringEnumConverter<WeightUnits>))]
    public enum WeightUnits
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

    public double Value { get; set; } = value;

    public WeightUnits Unit { get; set; } = unit;

    public double ConvertTo(WeightUnits weightUnit)
    {
        Value = Value * (GetMultiplier(Unit) / GetMultiplier(weightUnit));
        Unit = weightUnit;
        return Value;
    }
    
    public static double Convert(double value, WeightUnits from, WeightUnits to)
    {
        return value * (GetMultiplier(to) / GetMultiplier(from));
    }
    
    private static double GetMultiplier(WeightUnits weightUnit)
    {
        return weightUnit switch
        {
            WeightUnits.Milligram => MilligramMultiplier,
            WeightUnits.Gram => GramMultiplier,
            WeightUnits.Kilogram => KilogramMultiplier,
            WeightUnits.MetricTon => MetricTonMultiplier,
            WeightUnits.Ounce => OunceMultiplier,
            WeightUnits.Pound => PoundMultiplier,
            _ => throw new ArgumentOutOfRangeException(nameof(weightUnit), weightUnit, null)
        };
    }
    
    public override string ToString()
    {
        return $"{Value} {Unit.ToString()}";
    }
}