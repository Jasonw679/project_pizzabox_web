using PizzaBox.Storing.Repository;

namespace PizzaBox.Storing
{
  public class UnitOfWork
  {
    public readonly PizzaBoxContext _context;
    public StoreRepository Stores { get; set; }
    public CustomerRepository Customers { get; set; }
    public CrustRepository Crusts { get; set; }
    public SizeRepository Sizes { get; set; }
    public ToppingRepository Toppings { get; set; }
    public PizzaRepository Pizzas { get; set; }
    public OrderRepository Orders { get; set; }

    public UnitOfWork(PizzaBoxContext context)
    {
      _context = context;
      Stores = new StoreRepository(context);
      Customers = new CustomerRepository(context);
      Crusts = new CrustRepository(context);
      Sizes = new SizeRepository(context);
      Toppings = new ToppingRepository(context);
      Pizzas = new PizzaRepository(context);
      Orders = new OrderRepository(context);
    }

    public void Save()
    {
      _context.SaveChanges();
    }
  }
}