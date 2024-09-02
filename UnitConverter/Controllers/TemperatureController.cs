using Microsoft.AspNetCore.Mvc;
using Models;

namespace UnitConverter.Controllers;

public class TemperatureController : Controller
{
    // GET
    public IActionResult Index()
    {
        Console.WriteLine("Index");
        return View();
    }
    
    [HttpPost]
    public IActionResult Index(
        Temperature temp,
        Temperature.TemperatureUnits to)
    {
        Console.WriteLine($"POST Index {temp} {to}");
        temp.ConvertTo(to);
        //return View(length);
        return RedirectToAction("Result", temp);
    }

    [HttpGet]
    public IActionResult Result(Temperature temp)
    {
        Console.WriteLine($"Result {temp}");
        return View(temp);
    }
}