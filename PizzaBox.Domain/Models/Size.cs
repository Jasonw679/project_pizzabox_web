using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Size : AModel
  {
    public ICollection<Pizza> Pizzas { get; set; }
    public Size(string Name, double Price)
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