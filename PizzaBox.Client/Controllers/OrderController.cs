using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("order_history")]
  public class OrderController : Controller
  {
    private readonly UnitOfWork _unitOfWork;
    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [HttpPost]
    public IActionResult Index(OrderViewModel order)
    {
      order.Load(_unitOfWork);
      var orders = _unitOfWork.Orders.Select(c => c.Customer.Name == order.SelectedCustomer).ToList();
      ViewBag.Orders = orders;
      return View("order", order);
    }
  }
}