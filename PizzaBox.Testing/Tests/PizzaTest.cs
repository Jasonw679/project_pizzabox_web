using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System.Collections.Generic;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class PizzaTests
  {
    public static IEnumerable<object[]> values = new List<object[]>()
        {
            new object[] { new Pizza() },
        };
    [Theory]
    [MemberData(nameof(values))]
    public void Test_PizzaName(Pizza pizza)
    {
      Assert.Equal(pizza.Name, pizza.ToString());
    }
    [Fact]
    public void Test_PizzaPrice()
    {
      Assert.Equal(0.3, new Pizza() { Crust = new Crust("test", .2), Size = new Size("test", .1), Toppings = new List<Topping>() }.Price);
    }
  }
}