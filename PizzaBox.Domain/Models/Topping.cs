using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Topping : AModel
  {
    public List<Pizza> Pizzas = new List<Pizza>();

    public Topping(string Name, double Price)
    {
      this.Name = Name;
      this.Price = Price;
    }
    public string Name { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
      return Name;
    }
  }
}