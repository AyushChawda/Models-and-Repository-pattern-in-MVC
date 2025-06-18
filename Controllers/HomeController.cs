using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Repository_pattern.Models;
using Repository_pattern.Repository;

namespace Repository_pattern.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    
    // Reading the StudentRepository 
    private readonly StudentRepository _StudentRepository = null;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;

        // Creating the instance of StudentRepository to use its methods 
        _StudentRepository = new StudentRepository();
    }

    // Method to get that call the getAllStudent Method of StudentRepository 
    public List<StudentModel> getAllStudent()
    {
        return _StudentRepository.getAllStudent();
    }

    // Method to get that call the getStudentById Method of StudentRepository 
    public StudentModel getStudentById(int id)
    {
        return _StudentRepository.getStudentById(id);
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

    [HttpPost]
    public string Index(FormModel data)
    {
        return "Name :-" +data.Name+" Age :-"+data.Age+" Gander:-"+data.gander+" Email:-"+data.Email+" Passward:-"+data.Password;
    }


    public IActionResult About()
    {
        EmployeeModel emp = new EmployeeModel()
        {
            eId = 101,
            eName="Vaibhav",
            eAge=29,
            ePosition="Sells manager"

        };
        ViewBag.employee = emp;

        return View();
    }

    // Tag Helpers 
    public IActionResult Contact()
    {
        return View();
    }

    // Strongly typed view
    public IActionResult Privacy()
    {
        EmployeeModel emp = new EmployeeModel()
        {
            eId = 101,
            eName = "Vaibhav",
            eAge = 29,
            ePosition = "Sells manager"

        };
        return View(emp);
    }

  

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
