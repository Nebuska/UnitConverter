using Models;

namespace Tests.Models;

public class WeightTests
{
    [Fact]
    public void ConversionFromOneGramToKilogram()
    {
        // Arrange
        var weight = new Weight(1, Weight.WeightUnits.Gram);
        
        // Act
        var result = weight.ConvertTo(Weight.WeightUnits.Kilogram);
        
        // Assert
        Assert.Equal(0.001f, result);
    }
    
    [Fact]
    public void ConversionFromOneGramToMilligram()
    {
        // Arrange
        var weight = new Weight(1, Weight.WeightUnits.Gram);
        
        // Act
        var result = weight.ConvertTo(Weight.WeightUnits.Milligram);
        
        // Assert
        Assert.Equal(1000f, result);
    }
    
    [Fact]
    public void ConversionFromOneKilogramToGram()
    {
        // Arrange
        var weight = new Weight(1, Weight.WeightUnits.Kilogram);
        
        // Act
        var result = weight.ConvertTo(Weight.WeightUnits.Gram);
        
        // Assert
        Assert.Equal(1000f, result);
    }
    
    [Fact]
    public void ConversionFromOneKilogramToMilligram()
    {
        // Arrange
        var weight = new Weight(1, Weight.WeightUnits.Kilogram);
        
        // Act
        var result = weight.ConvertTo(Weight.WeightUnits.Milligram);
        
        // Assert
        Assert.Equal(1000000f, result);
    }
    
    [Fact]
    public void ConversionFromOneMilligramToGram()
    {
        // Arrange
        var weight = new Weight(1, Weight.WeightUnits.Milligram);
        
        // Act
        var result = weight.ConvertTo(Weight.WeightUnits.Gram);
        
        // Assert
        Assert.Equal(0.001f, result);
    }
    
    [Fact]
    public void ConversionFromOneMilligramToKilogram()
    {
        // Arrange
        var weight = new Weight(1, Weight.WeightUnits.Milligram);
        
        // Act
        var result = weight.ConvertTo(Weight.WeightUnits.Kilogram);
        
        // Assert
        Assert.Equal(0.000001f, result);
    }
}