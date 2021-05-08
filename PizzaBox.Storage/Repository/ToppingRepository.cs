using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interface;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
  public class ToppingRepository : IRepository<Topping>
  {
    private readonly PizzaBoxContext _context;

    public ToppingRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Topping entry)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Topping> Select(Func<Topping, bool> filter)
    {
      return _context.Toppings.Where(filter);
      //return new List<Topping>() { new Topping("Cheese", .2f), new Topping("Tomato", .1f), new Topping("Pepperoni", .3f) };
    }

    public Topping Update()
    {
      throw new System.NotImplementedException();
    }
  }
}