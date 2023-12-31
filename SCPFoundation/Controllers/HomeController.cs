using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SCPFoundation.Models;

namespace SCPFoundation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Main()
    {
        return View();
    }

    public IActionResult Cards()
    {
        return View();
    }

    public IActionResult Description()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}