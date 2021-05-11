using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Pizza : AModel
  {
    public string Name { get; set; }
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Toppings { get; set; }
    public List<Order> Order { get; set; }

    public Double Price
    {
      get
      {
        return computePrice();
      }
    }

    public override string ToString()
    {
      return Name;
    }
    private Double computePrice()
    {
      var price = 0.0;
      foreach (Topping t in Toppings)
      {
        price += t.Price;
      }
      price += Crust.Price;
      price += Size.Price;
      return Math.Round(price, 2);
    }
  }
}