using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Interface;
using System.Linq;
using System;

namespace PizzaBox.Storing.Repository
{
  public class CrustRepository : IRepository<Crust>
  {
    private readonly PizzaBoxContext _context;

    public CrustRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Crust entry)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Crust> Select(Func<Crust, bool> filter)
    {
      return _context.Crusts.Where(filter);
    }

    public Crust Update()
    {
      throw new System.NotImplementedException();
    }
  }
}