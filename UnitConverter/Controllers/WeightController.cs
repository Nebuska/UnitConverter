using Microsoft.AspNetCore.Mvc;
using Models;

namespace UnitConverter.Controllers;

public class WeightController : Controller
{
    // GET
    public IActionResult Index()
    {
        Console.WriteLine("Index");
        return View();
    }
    
    [HttpPost]
    public IActionResult Index(
        Weight weight,
        Weight.WeightUnits to)
    {
        Console.WriteLine($"POST Index {weight} {to}");
        weight.ConvertTo(to);
        return RedirectToAction("Result", weight);
    }

    [HttpGet]
    public IActionResult Result(Weight weight)
    {
        Console.WriteLine($"Result {weight}");
        return View(weight);
    }
}