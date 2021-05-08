using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interface;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
  public class PizzaRepository : IRepository<Pizza>
  {
    private readonly PizzaBoxContext _context;
    public PizzaRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public bool Delete()
    {
      throw new NotImplementedException();
    }

    public bool Insert(Pizza entry)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Pizza> Select(Func<Pizza, bool> filter)
    {
      throw new NotImplementedException();
    }

    public Pizza Update()
    {
      throw new NotImplementedException();
    }
  }
}
