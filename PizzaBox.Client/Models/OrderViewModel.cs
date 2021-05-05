using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel : IValidatableObject
  {
    public List<string> Crusts { get; set; } = new List<string> { "Thin", "Medium", "Thick" };
    public List<string> Sizes { get; set; } = new List<string> { "Small", "Medium", "Large" };
    public List<string> Toppings { get; set; } = new List<string> { "pepponi", "cheese", "tomato sauce" };
    [Required(ErrorMessage = "no crust")]
    [DataType(DataType.Text)]
    public string SelectedCrust { get; set; }
    [Required(ErrorMessage = "no size")]
    [DataType(DataType.Text)]
    public string SelectedSize { get; set; }
    [Required(ErrorMessage = "no toppings")]
    [DataType(DataType.Text)]
    [Range(2, 5)]
    public List<string> SelectedToppings { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext v)
    {
      if (SelectedCrust == SelectedSize)
      {
        yield return new ValidationResult("Error", new string[] { "Selected Crust" });
      }
      if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
      {
        yield return new ValidationResult("Error", new string[] { "Selected Toppings" });
      }
    }
  }
}