using Microsoft.AspNetCore.Mvc;
using Models;

namespace UnitConverter.Controllers;

public class LengthController : Controller
{
    // GET
    public IActionResult Index()
    {
        Console.WriteLine("Index");
        return View();
    }
    
    [HttpPost]
    public IActionResult Index(
        Length length,
        Length.LengthUnits to)
    {
        Console.WriteLine($"POST Index {length} {to}");
        length.ConvertTo(to);
        //return View(length);
        return RedirectToAction("Result", length);
    }

    [HttpGet]
    public IActionResult Result(Length length)
    {
        Console.WriteLine($"Result {length}");
        return View(length);
    }
}