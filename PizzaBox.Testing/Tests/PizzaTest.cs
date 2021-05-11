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
            new object[] { new Pizza() }
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
      Assert.Equal(new Pizza().Price, 2.4);
      Assert.Equal(new Pizza().Price, 2.45);
    }
  }
}