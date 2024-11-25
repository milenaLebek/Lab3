using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using zadanie1.Models;

namespace zadanie1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(new UserModel());
    }

    [HttpPost]
    public IActionResult Index(UserModel user)
    {
        if (ModelState.IsValid)
        {
            TempData["Message"] = "Uzytkownik stworzony poprawnie!";
            return RedirectToAction("Index");
        }

        return View(user);
    }
}