using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interface;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
  public class OrderRepository : IRepository<Order>
  {
    private readonly PizzaBoxContext _context;

    public OrderRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Order entry)
    {
      return _context.Orders.Add(entry).IsKeySet;
    }

    public IEnumerable<Order> Select(Func<Order, bool> filter)
    {
      return _context.Orders.Where(filter);
    }

    public Order Update()
    {
      throw new System.NotImplementedException();
    }
  }
}