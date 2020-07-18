using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
  public class Pizza
  {
    // STATE
    //fields
    private readonly string ImageUrl = "";
    private double Diameter = 0;
    private static string _name = "pizza";
    private List<string> _toppings = new List<string>();

    //properties

    public string Size { get; }
    
    public string Crust { get; }

    public List<string> Toppings
    {
      get
      {
        return _toppings;
      }
    }

    // BEHAVIOR
    //methods
    void AddToppings(string topping)
    {
      Toppings.Add(topping);
    }

    public override string ToString()
    {
      var sb = new StringBuilder();

      foreach(var t in Toppings)
      {
        sb.Append(t + ", ");
      }
      return $"{Crust} \n{Size} \n{sb}";
    }
    //constructors

    public Pizza(string size, string crust, List<string> toppings)
    {
      Size = size;
      Crust = crust;
      Toppings.AddRange(toppings);
    }

    public Pizza()
    {
      //Intentionally empty
    }
    //finalizers/deconstructors
  }
}