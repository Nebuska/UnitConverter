using Microsoft.AspNetCore.Mvc;
using Models;

namespace Api.Controllers;

[ApiController]
[Route("converter")]
public class ConverterController : ControllerBase
{
    [HttpPost("length")]
    public Length ConvertLength(
        [FromBody] Length length, [FromQuery] Length.LengthUnits to)
    {
        Console.WriteLine("Converting length to " + to);
        length.ConvertTo(to);
        return length;
    }
    
    [HttpPost("temperature")]
    public Temperature ConvertTemperature(
        [FromBody] Temperature temperature, [FromQuery] Temperature.TemperatureUnits to)
    {
        temperature.ConvertTo(to);
        return temperature;
    }
    
    [HttpPost("weight")]
    public Weight ConvertWeight(
        [FromBody] Weight weight, [FromQuery] Weight.WeightUnits to)
    {
        weight.ConvertTo(to);
        return weight;
    }
}