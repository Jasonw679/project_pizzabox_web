namespace PizzaBox.Client.Controllers
{
  [Route("[controller]/[action]")]
  public class HomeController : Controllers
  {
    [HttpGet]
    public IActionResult Index()
    {
      return View();
    }
  }
}