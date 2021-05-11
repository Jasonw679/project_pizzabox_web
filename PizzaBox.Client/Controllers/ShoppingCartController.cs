using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("shopping_cart")]
  public class ShoppingCartController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public ShoppingCartController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [HttpPost]
    public IActionResult Index(OrderVerifyController order)
    {
      return View("ShoppingCart", order);
    }
  }
}