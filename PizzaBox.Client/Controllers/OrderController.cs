using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("Order")]
  public class OrderController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpGet]
    public IActionResult Index(OrderViewModel order)
    {
      order.Load(_unitOfWork);
      return View("order", order);
    }
  }
}