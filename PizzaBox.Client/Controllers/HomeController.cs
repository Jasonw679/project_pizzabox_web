using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("Home")]
  public class HomeController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public HomeController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [HttpPost]
    public IActionResult Index(OrderViewModel order)
    {
      order.Load(_unitOfWork);
      if (order.SelectedCustomer != null)
      {
        var customer = _unitOfWork.Customers.Select(c => c.Name == order.SelectedCustomer);
        if (customer.Count() == 0)
        {
          _unitOfWork.Customers.Insert(new Customer(order.SelectedCustomer));
          _unitOfWork.Save();
        }
      }
      else
      {
        return View("customer", order);
      }
      ViewBag.Order = new Order();
      return View("index", order);
    }
  }
}