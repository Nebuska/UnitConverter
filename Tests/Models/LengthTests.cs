using Models;
using UnitConverter.Models;

namespace Tests.Models;

public class LengthTests
{
    [Fact]
    public void ConversionFromOneMillimeterToCentimeter()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Millimeter);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Centimeter);
        
        // Assert
        Assert.Equal(0.1f, result);
    }

    [Fact]
    public void ConversionFromOneMillimeterToMeter()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Millimeter);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Meter);
        
        // Assert
        Assert.Equal(0.001f, result);
    }
    
    [Fact]
    public void ConversionFromOneMillimeterToKilometer()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Millimeter);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Kilometer);
        
        // Assert
        Assert.Equal(0.000001f, result);
    }
    
    [Fact]
    public void ConversionFromOneCentimeterToMillimeter()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Centimeter);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Millimeter);
        
        // Assert
        Assert.Equal(10, result);
    }
    
    
    [Fact]
    public void ConversionFromOneCentimeterToMeter()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Centimeter);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Meter);
        
        // Assert
        Assert.Equal(0.01f, result);
    }
    
    [Fact]
    public void ConversionFromOneCentimeterToKilometer()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Centimeter);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Kilometer);
        
        // Assert
        Assert.Equal(0.00001f, result);
    }
    
    [Fact]
    public void ConversionFromOneMeterToMillimeter()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Meter);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Millimeter);
        
        // Assert
        Assert.Equal(1000, result);
    }
    
    [Fact]
    public void ConversionFromOneMeterToCentimeter()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Meter);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Centimeter);
        
        // Assert
        Assert.Equal(100, result);
    }
    
    [Fact]
    public void ConversionFromOneMeterToKilometer()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Meter);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Kilometer);
        
        // Assert
        Assert.Equal(0.001f, result);
    }
    
    [Fact]
    public void ConversionFromOneKilometerToMillimeter()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Kilometer);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Millimeter);
        
        // Assert
        Assert.Equal(1000000, result);
    }
    
    [Fact]
    public void ConversionFromOneKilometerToCentimeter()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Kilometer);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Centimeter);
        
        // Assert
        Assert.Equal(100000, result);
    }
    
    [Fact]
    public void ConversionFromOneKilometerToMeter()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Kilometer);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Meter);
        
        // Assert
        Assert.Equal(1000, result);
    }
    
    [Fact]
    public void ConversionFromOneInchToFoot()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Inch);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Foot);
        
        // Assert
        Assert.Equal(1f / 12, result);
    }
    
    [Fact]
    public void ConversionFromOneFootToInch()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Foot);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Inch);
        
        // Assert
        Assert.Equal(12, result);
    }
    
    [Fact]
    public void ConversionFromOneFootToYard()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Foot);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Yard);
        
        // Assert
        Assert.Equal(1f / 3, result);
    }
    
    [Fact]
    public void ConversionFromYardToMile()
    {
        // Arrange
        var length = new Length(1760, Length.LengthUnits.Yard);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Mile);
        
        // Assert
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void ConversionFromMileToYard()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Mile);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Yard);
        
        // Assert
        Assert.Equal(1760, result);
    }
    
    [Fact]
    public void ConversionFromYardToFoot()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Yard);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Foot);
        
        // Assert
        Assert.Equal(3, result);
    }
    
    [Fact]
    public void ConversionFromFootToInch()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Foot);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Inch);
        
        // Assert
        Assert.Equal(12, result);
    }
    
    [Fact]
    public void ConversionFromInchToMeter()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Inch);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Meter);
        
        // Assert
        Assert.Equal(0.0254, result);
    }
    
    [Fact]
    public void ConversionFromMeterToInch()
    {
        // Arrange
        var length = new Length(1, Length.LengthUnits.Meter);
        
        // Act
        var result = length.ConvertTo(Length.LengthUnits.Inch);
        
        // Assert
        Assert.Equal(39.37007874015748, result);
    }
}