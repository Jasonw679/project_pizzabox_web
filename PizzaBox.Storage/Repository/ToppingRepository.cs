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
      return _context.Toppings.Add(entry).IsKeySet;
    }

    public IEnumerable<Topping> Select(Func<Topping, bool> filter)
    {
      return _context.Toppings.Where(filter);
    }

    public Topping Update()
    {
      throw new System.NotImplementedException();
    }
  }
}