using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Interface;
using System.Linq;
using System;

namespace PizzaBox.Storing.Repository
{
  public class CustomerRepository : IRepository<Customer>
  {
    private readonly PizzaBoxContext _context;

    public CustomerRepository(PizzaBoxContext context)
    {
      _context = context;
    }

    public bool Delete()
    {
      throw new NotImplementedException();
    }

    public bool Insert(Customer entry)
    {
      return _context.Customers.Add(entry).IsKeySet;
    }

    public IEnumerable<Customer> Select(Func<Customer, bool> filter)
    {
      return _context.Customers.Where(filter);
    }

    public Customer Update()
    {
      throw new NotImplementedException();
    }
  }
}