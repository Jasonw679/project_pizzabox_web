using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {
    public DbSet<Store> Stores { get; set; }
    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Topping> Toppings { get; set; }
    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<Order> Orders { get; set; }
    public PizzaBoxContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Store>().HasKey(e => e.EntityId);
      builder.Entity<Pizza>().HasKey(e => e.EntityId);
      builder.Entity<Customer>().HasKey(e => e.EntityId);
      builder.Entity<Order>().HasKey(e => e.EntityId);
      builder.Entity<Crust>().HasKey(e => e.EntityId);
      builder.Entity<Size>().HasKey(e => e.EntityId);
      builder.Entity<Topping>().HasKey(e => e.EntityId);

      OnModelSeeding(builder);
    }
    public void OnModelSeeding(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasData(new[]
      {
        new Crust("Thin", .75f) {EntityId = 1},
        new Crust("Medium", 1.0f) {EntityId = 2},
        new Crust("Thick", 1.25f) {EntityId = 3}
      });

      builder.Entity<Size>().HasData(new[]
      {
        new Size("Small", .75f) {EntityId = 1},
        new Size("Medium", 1.0f) {EntityId = 2},
        new Size("Large", 1.2f) {EntityId = 3}
      });

      builder.Entity<Topping>().HasData(new[]
      {
        new Topping("Cheese", .2f) {EntityId = 1},
        new Topping("Tomato", .1f) {EntityId = 2},
        new Topping("Pepperoni", .3f) {EntityId = 3}
      });
    }
  }
}