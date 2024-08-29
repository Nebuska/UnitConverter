using System.Text.Json.Serialization;

namespace Models;

public class Temperature(double value, Temperature.TemperatureUnits temperatureUnit)
{
    [JsonConverter(typeof(JsonStringEnumConverter<Temperature.TemperatureUnits>))]
    public enum TemperatureUnits
    {
        Kelvin,
        Celsius,
        Fahrenheit
    }
    
    public double Value { get; set; } = value;

    public TemperatureUnits TemperatureUnit { get; set; } = temperatureUnit;
    
    public double ConvertTo(TemperatureUnits temperatureUnit)
    {
        Value = temperatureUnit switch
        {
            TemperatureUnits.Kelvin => TemperatureUnit switch
            {
                TemperatureUnits.Celsius => Value + 273.15,
                TemperatureUnits.Fahrenheit => (Value + 459.67) * 5 / 9,
                _ => Value
            },
            TemperatureUnits.Celsius => TemperatureUnit switch
            {
                TemperatureUnits.Kelvin => Value - 273.15,
                TemperatureUnits.Fahrenheit => Value * 9 / 5 + 32,
                _ => Value
            },
            TemperatureUnits.Fahrenheit => TemperatureUnit switch
            {
                TemperatureUnits.Kelvin => (Value - 32) * 5 / 9 + 273.15,
                TemperatureUnits.Celsius => (Value - 32) * 5 / 9,
                _ => Value
            },
            _ => Value
        };
        TemperatureUnit = temperatureUnit;
        return Value;
    }
}