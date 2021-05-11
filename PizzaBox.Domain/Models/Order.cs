using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Order : AModel
  {
    public Store Store { get; set; }
    public List<Pizza> Pizzas { get; set; }
    public Customer Customer { get; set; }
    public override string ToString()
    {
      double price = 0.0;
      string result = "";
      for (var i = 0; i < Pizzas.Count; i += 1)
      {
        if (i == Pizzas.Count - 1 && Pizzas.Count > 1)
        {
          result += "and ";
        }
        result += Pizzas[i] + $" in {Pizzas[i].Crust} crust with";
        foreach (var top in Pizzas[i].Toppings)
        {
          result += $" {top} ";
        }
        if (i < Pizzas.Count - 1)
        {
          result += ", ";
        }
        result += "\n";
        price += Pizzas[i].Price;
      }
      return $"{result}order in {Store}, Final Price: {price}";
    }
  }
}