using Models;

namespace Tests.Models;

public class TemperatureTests
{
    [Fact]
    public void ConversionFromOneCelsiusToFahrenheit()
    {
        // Arrange
        var temperature = new Temperature(1, Temperature.TemperatureUnits.Celsius);
        
        // Act
        var result = temperature.ConvertTo(Temperature.TemperatureUnits.Fahrenheit);
        
        // Assert
        Assert.Equal(33.8f, result);
    }
    
    [Fact]
    public void ConversionFromOneCelsiusToKelvin()
    {
        // Arrange
        var temperature = new Temperature(1, Temperature.TemperatureUnits.Celsius);
        
        // Act
        var result = temperature.ConvertTo(Temperature.TemperatureUnits.Kelvin);
        
        // Assert
        Assert.Equal(274.15f, result);
    }
    
    [Fact]
    public void ConversionFromOneFahrenheitToCelsius()
    {
        // Arrange
        var temperature = new Temperature(1, Temperature.TemperatureUnits.Fahrenheit);
        
        // Act
        var result = temperature.ConvertTo(Temperature.TemperatureUnits.Celsius);
        
        // Assert
        Assert.Equal(-17.222222f, result);
    }
    
    [Fact]
    public void ConversionFromOneFahrenheitToKelvin()
    {
        // Arrange
        var temperature = new Temperature(1, Temperature.TemperatureUnits.Fahrenheit);
        
        // Act
        var result = temperature.ConvertTo(Temperature.TemperatureUnits.Kelvin);
        
        // Assert
        Assert.Equal(255.92778f, result);
    }
    
    [Fact]
    public void ConversionFromOneKelvinToCelsius()
    {
        // Arrange
        var temperature = new Temperature(1, Temperature.TemperatureUnits.Kelvin);
        
        // Act
        var result = temperature.ConvertTo(Temperature.TemperatureUnits.Celsius);
        
        // Assert
        Assert.Equal(-272.15f, result);
    }
    
    [Fact]
    public void ConversionFromOneKelvinToFahrenheit()
    {
        // Arrange
        var temperature = new Temperature(1, Temperature.TemperatureUnits.Kelvin);
        
        // Act
        var result = temperature.ConvertTo(Temperature.TemperatureUnits.Fahrenheit);
        
        // Assert
        Assert.Equal(-457.87f, result);
    }
}