using PizzaBox.Domain.Models;
using System.Collections.Generic;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class StoreTests
  {
    public static IEnumerable<object[]> values = new List<object[]>()
        {
            new object[] { new Store("test")},
        };
    [Theory]
    [MemberData(nameof(values))]
    public void Test_StoreName(Store store)
    {
      Assert.NotNull(store.Name);
      Assert.Equal(store.Name, store.ToString());
    }
    public void Test_StoreOrder(Store store)
    {
      Assert.NotNull(store.Orders);
    }
  }
}