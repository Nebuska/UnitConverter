namespace Models;

public class Length(double value, Length.Units unit)
{
    public enum Units
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
            Units.Millimeter => MillimeterMultiplier,
            Units.Centimeter => CentimeterMultiplier,
            Units.Meter => MeterMultiplier,
            Units.Kilometer => KilometerMultiplier,
            Units.Inch => InchMultiplier,
            Units.Foot => FootMultiplier,
            Units.Yard => YardMultiplier,
            Units.Mile => MileMultiplier,
            _ => throw new ArgumentOutOfRangeException(nameof(unit), unit, null)
        };
    }
}