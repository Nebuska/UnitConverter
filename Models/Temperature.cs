namespace Models;

public class Temperature(double value, Temperature.Units unit)
{
    public enum Units
    {
        Kelvin,
        Celsius,
        Fahrenheit
    }
    
    public double Value { get; set; } = value;

    public Units Unit { get; set; } = unit;
    
    public double ConvertTo(Units unit)
    {
        Value = unit switch
        {
            Units.Kelvin => Unit switch
            {
                Units.Celsius => Value + 273.15,
                Units.Fahrenheit => (Value + 459.67) * 5 / 9,
                _ => Value
            },
            Units.Celsius => Unit switch
            {
                Units.Kelvin => Value - 273.15,
                Units.Fahrenheit => Value * 9 / 5 + 32,
                _ => Value
            },
            Units.Fahrenheit => Unit switch
            {
                Units.Kelvin => (Value - 32) * 5 / 9 + 273.15,
                Units.Celsius => (Value - 32) * 5 / 9,
                _ => Value
            },
            _ => Value
        };
        Unit = unit;
        return Value;
    }
}