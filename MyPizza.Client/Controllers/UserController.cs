using Microsoft.AspNetCore.Mvc;
using MyPizza.Client.Models;

namespace MyPizza.Client.Controllers
{
  public class UserController : Controller
  {
    
    [HttpGet]
    public IActionResult History(int userId)
    {
      return View("User");
    }
    [HttpGet]
    public IActionResult Order()
    {
      return View("User");
    }

  }
}