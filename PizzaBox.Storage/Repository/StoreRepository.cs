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
      return _context.Stores.Add(entry).IsKeySet;
    }

    public IEnumerable<Store> Select(Func<Store, bool> filter)
    {
      return _context.Stores.Where(filter);
    }

    public Store Update()
    {
      throw new System.NotImplementedException();
    }
  }
}