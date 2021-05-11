using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Customer : AModel
  {
    public string Name { get; set; }
    public List<Order> orders = new List<Order>();

    public Customer(string name)
    {
      Name = name;
    }

    public override string ToString()
    {
      return Name;
    }
  }
}