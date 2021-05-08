using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Interface
{
  public interface IRepository<T> where T : class
  {
    public IEnumerable<T> Select(Func<T, bool> filter);
    public bool Insert(T entry);
    public T Update();
    public bool Delete();
  }
}