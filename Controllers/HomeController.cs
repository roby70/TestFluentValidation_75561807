using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestFluentValidation.Models;

namespace TestFluentValidation.Controllers;
public class HomeController : Controller {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) {
        _logger = logger;
    }

    public IActionResult Index() {
        return View();
    }

    public IActionResult Privacy() {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet]

    public IActionResult LogIn() {
        var model = new LogInVM();
        return View(model);
    }

    [HttpPost]
    public IActionResult LogIn(LogInVM model) {
        if (!ModelState.IsValid) {
            return View(model);
        }
        throw new NotImplementedException();
    }
}
