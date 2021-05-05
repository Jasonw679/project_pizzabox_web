using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
  [Route("Order")]
  public class OrderController : Controller
  {
    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        return View("order");
      }
      return View("bad request");
    }
  }
}