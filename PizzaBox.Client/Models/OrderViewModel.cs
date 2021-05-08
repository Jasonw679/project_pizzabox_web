using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel : IValidatableObject
  {
    public List<Crust> Crusts { get; set; }
    public List<Size> Sizes { get; set; }
    public List<Topping> Toppings { get; set; }
    [Required(ErrorMessage = "Please Select a Crust")]
    [DataType(DataType.Text)]
    public string SelectedCrust { get; set; }
    [Required(ErrorMessage = "Please Select a Size")]
    [DataType(DataType.Text)]
    public string SelectedSize { get; set; }
    [Required(ErrorMessage = "Please Selece a Topping")]
    [DataType(DataType.Text)]
    [Range(2, 5)]
    public List<string> SelectedToppings { get; set; }

    public void Load(UnitOfWork unitOfWork)
    {
      Crusts = unitOfWork.Crusts.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Sizes = unitOfWork.Sizes.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Toppings = unitOfWork.Toppings.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
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