using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
  [Route("Home")]
  public class HomeController : Controller
  {
    [HttpGet]
    public IActionResult Index()
    {
      return View("index", new OrderViewModel());
    }
  }
}