using System.Text.Json.Serialization;

namespace Models;

public class Length(double value, Length.LengthUnits unit)
{
    public Length() : this(0, default)
    {}
    
    [JsonConverter(typeof(JsonStringEnumConverter<LengthUnits>))]
    public enum LengthUnits
    {
        Millimeter,
        Centimeter,
        Meter,
        Kilometer,
        Inch,
        Foot,
        Yard,
        Mile
    }
    
    private const double MillimeterMultiplier = 1;
    private const double CentimeterMultiplier = 10 * MillimeterMultiplier;
    private const double MeterMultiplier = 100 * CentimeterMultiplier;
    private const double KilometerMultiplier = 1000 * MeterMultiplier;
    private const double InchMultiplier = 25.4 * MillimeterMultiplier;
    private const double FootMultiplier = 12 * InchMultiplier;
    private const double YardMultiplier = 3 * FootMultiplier;
    private const double MileMultiplier = 1760 * YardMultiplier;

    public double Value { get; set; } = value;

    public LengthUnits Unit { get; set; } = unit;

    public double ConvertTo(LengthUnits lengthUnit)
    {
        Value = Value * (GetMultiplier(Unit) / GetMultiplier(lengthUnit));
        Unit = lengthUnit;
        return Value;
    }
    
    public static double Convert(double value, LengthUnits from, LengthUnits to)
    {
        return value * (GetMultiplier(to) / GetMultiplier(from));
    }

    private static double GetMultiplier(LengthUnits lengthUnit)
    {
        return lengthUnit switch
        {
            LengthUnits.Millimeter => MillimeterMultiplier,
            LengthUnits.Centimeter => CentimeterMultiplier,
            LengthUnits.Meter => MeterMultiplier,
            LengthUnits.Kilometer => KilometerMultiplier,
            LengthUnits.Inch => InchMultiplier,
            LengthUnits.Foot => FootMultiplier,
            LengthUnits.Yard => YardMultiplier,
            LengthUnits.Mile => MileMultiplier,
            _ => throw new ArgumentOutOfRangeException(nameof(lengthUnit), lengthUnit, null)
        };
    }

    public override string ToString()
    {
        return $"{Value} {Unit.ToString()}";
    }
}