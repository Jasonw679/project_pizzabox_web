using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("Checkout")]
  public class CheckoutController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public CheckoutController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        var crust = _unitOfWork.Crusts.Select(c => c.Name == order.SelectedCrust).First();
        var size = _unitOfWork.Sizes.Select(c => c.Name == order.SelectedSize).First();
        var topping = new List<Topping>();
        foreach (var item in order.SelectedToppings)
        {
          topping.Add(_unitOfWork.Toppings.Select(c => c.Name == item).First());
        }

        var pizza = new Pizza() { Crust = crust, Size = size, Toppings = topping };
        var newOrder = new Order() { Pizzas = new List<Pizza> { pizza } };
        _unitOfWork.Orders.Insert(newOrder);
        _unitOfWork.Save();
        ViewBag.Order = newOrder;
        return View("checkout");
      }
      order.Load(_unitOfWork);
      return View("order", order);
    }
  }
}