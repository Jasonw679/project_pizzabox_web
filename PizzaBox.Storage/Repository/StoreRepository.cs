using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Interface;
using System.Linq;
using System;

namespace PizzaBox.Storing.Repository
{
  public class StoreRepository : IRepository<Store>
  {
    private readonly PizzaBoxContext _context;

    public StoreRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Store entry)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Store> Select(Func<Store, bool> filter)
    {
      return _context.Stores.Where(filter);
      //return new List<Crust> { new Crust("Thin", .75f), new Crust("Medium", 1.0f), new Crust("Thick", 1.25f) };
    }

    public Store Update()
    {
      throw new System.NotImplementedException();
    }
  }
}