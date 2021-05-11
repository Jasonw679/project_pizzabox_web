using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("customer")]
  public class CustomerController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public CustomerController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpGet]
    public IActionResult Index(OrderViewModel order)
    {
      order.Load(_unitOfWork);
      ViewBag.Orders = _unitOfWork.Orders.Select(c => c.Customer.Name == order.SelectedCustomer).ToList();
      return View("customer", order);
    }
  }
}