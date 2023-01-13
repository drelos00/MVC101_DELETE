using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;
using Mvc101.Models;

namespace Mvc101.Controllers;

// The name of this controller is "Home"
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    // Constructor
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string[] days =
        {
            "Monday", "Tuesday", "Wednesday", "Thursday",
            "Friday", "Saturday", "Sunday"
        };

        ViewData["days"] = days;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Bogus()
    {
        string[] days =
        {
            "Monday", "Tuesday", "Wednesday", "Thursday",
            "Friday", "Saturday", "Sunday"
        };
        
        ViewData["author"] = "Jane Bond";
        ViewBag.Date = DateTime.Now;
        return View(days); 
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
