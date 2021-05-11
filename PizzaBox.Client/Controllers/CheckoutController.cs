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
      order.Load(_unitOfWork);
      if (ModelState.IsValid)
      {
        var store = _unitOfWork.Stores.Select(c => c.Name == order.SelectedStore).First();
        var customer = _unitOfWork.Customers.Select(c => c.Name == order.SelectedCustomer).First();
        var crust = _unitOfWork.Crusts.Select(c => c.Name == order.SelectedCrust).First();
        var size = _unitOfWork.Sizes.Select(c => c.Name == order.SelectedSize).First();
        var topping = new List<Topping>();
        foreach (var item in order.SelectedToppings)
        {
          topping.Add(_unitOfWork.Toppings.Select(c => c.Name == item).First());
        }

        var pizza = new Pizza() { Name = "Custom", Crust = crust, Size = size, Toppings = topping };
        var newOrder = new Order() { Store = store, Pizzas = new List<Pizza> { pizza }, Customer = customer };
        _unitOfWork.Orders.Insert(newOrder);
        _unitOfWork.Save();
        ViewBag.Order = newOrder;
        return View("checkout", order);
      }
      order.Load(_unitOfWork);
      return View("index", order);
    }
  }
}