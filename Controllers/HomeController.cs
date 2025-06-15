using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Repository_pattern.Models;

namespace Repository_pattern.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var student = new List<StudentModel>
        {
            new StudentModel{rollNo=1,name="Gautam",gander="male",standard=12},
            new StudentModel{rollNo=2,name="Animesh",gander="male",standard=8},
            new StudentModel{rollNo=3,name="Vishnu",gander="male",standard=9},
            new StudentModel{rollNo=4,name="Raghav",gander="male",standard=11},
            new StudentModel{rollNo=5,name="Surbhi",gander="female",standard=10},
        };
        ViewData["student"] = student;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
