using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class OrderTest
  {
    [Fact]
    public void Test_Order()
    {
      var o = new Order();
      o.Pizzas.Add(new Pizza());
      o.Pizzas.Add(new Pizza());
      o.Customer = new Customer("Test");
      Assert.Equal(o.Pizzas.Count, 2);
      Assert.Equal(o.Customer.Name, "Test");
    }
  }
}