using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel : IValidatableObject
  {
    public List<Store> Stores { get; set; }
    public List<Customer> Customers { get; set; }
    public List<Crust> Crusts { get; set; }
    public List<Size> Sizes { get; set; }
    public List<Topping> Toppings { get; set; }
    public List<Order> Orders { get; set; }
    [Required(ErrorMessage = "Please Select a Store")]
    [DataType(DataType.Text)]
    public string SelectedStore { get; set; }
    public string SelectedCustomer { get; set; }
    [Required(ErrorMessage = "Please Select a Crust")]
    [DataType(DataType.Text)]

    public string SelectedCrust { get; set; }
    [Required(ErrorMessage = "Please Select a Size")]
    [DataType(DataType.Text)]
    public string SelectedSize { get; set; }
    [Required(ErrorMessage = "Please Selece a Topping")]
    [DataType(DataType.Text)]
    //[Range(2, 5)]
    public List<string> SelectedToppings { get; set; }
    public string SelectedPizza { get; set; }

    public void Load(UnitOfWork unitOfWork)
    {
      Stores = unitOfWork.Stores.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Customers = unitOfWork.Customers.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Crusts = unitOfWork.Crusts.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Sizes = unitOfWork.Sizes.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Toppings = unitOfWork.Toppings.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Orders = unitOfWork.Orders.Select(c => !string.IsNullOrWhiteSpace(c.Store.Name)).ToList();
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext v)
    {
      if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
      {
        yield return new ValidationResult("please select 2 to 5 toppings.");
      }
    }
  }
}