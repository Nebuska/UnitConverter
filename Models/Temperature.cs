using System.Text.Json.Serialization;

namespace Models;

public class Temperature(double value, Temperature.TemperatureUnits unit)
{
    public Temperature() : this(0, default)
    {}
    
    
    [JsonConverter(typeof(JsonStringEnumConverter<TemperatureUnits>))]
    public enum TemperatureUnits
    {
        Kelvin,
        Celsius,
        Fahrenheit
    }
    
    public double Value { get; set; } = value;

    public TemperatureUnits Unit { get; set; } = unit;
    
    public double ConvertTo(TemperatureUnits temperatureUnit)
    {
        Value = temperatureUnit switch
        {
            TemperatureUnits.Kelvin => Unit switch
            {
                TemperatureUnits.Celsius => Value + 273.15,
                TemperatureUnits.Fahrenheit => (Value + 459.67) * 5 / 9,
                _ => Value
            },
            TemperatureUnits.Celsius => Unit switch
            {
                TemperatureUnits.Kelvin => Value - 273.15,
                TemperatureUnits.Fahrenheit => Value * 9 / 5 + 32,
                _ => Value
            },
            TemperatureUnits.Fahrenheit => Unit switch
            {
                TemperatureUnits.Kelvin => (Value - 32) * 5 / 9 + 273.15,
                TemperatureUnits.Celsius => (Value - 32) * 5 / 9,
                _ => Value
            },
            _ => Value
        };
        Unit = temperatureUnit;
        return Value;
    }
    
    public override string ToString()
    {
        return $"{Value} {Unit.ToString()}";
    }
}