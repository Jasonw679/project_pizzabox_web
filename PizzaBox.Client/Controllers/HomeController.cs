using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("Home")]
  public class HomeController : Controller
  {
    [HttpGet]
    public IActionResult Index()
    {
      return View("index");
    }
  }
}