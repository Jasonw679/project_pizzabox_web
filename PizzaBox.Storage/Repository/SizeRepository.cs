using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interface;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
  public class SizeRepository : IRepository<Size>
  {
    private readonly PizzaBoxContext _context;

    public SizeRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Size entry)
    {
      throw new System.NotImplementedException();
    }

    public System.Collections.Generic.IEnumerable<Size> Select(Func<Size, bool> filter)
    {
      return _context.Sizes.Where(filter);
      //return new List<Size>() { new Size("Small", .75f), new Size("Medium", 1.0f), new Size("Large", 1.2f) };
    }

    public Size Update()
    {
      throw new System.NotImplementedException();
    }
  }
}