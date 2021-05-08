using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Client.Controllers
{
  [Route("Pizza")]
  public class PizzaController : Controller
  {
    [HttpGet]
    public IActionResult Index()
    {
      return View("pizza");
    }
  }
}