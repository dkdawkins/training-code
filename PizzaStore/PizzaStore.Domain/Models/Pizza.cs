using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
  public class Pizza
  {
    // STATE
    //fields
    string ImageUrl = "";
    double Diameter = 0;
    public string Size = "";
    public List<string> Toppings = new List<string>();
    public string Crust = "";

    //properties

    public string SizeP { get; }
    
    public string CrustP { get; }

    public List<string> ToppingsP
    {
      get
      {
        return Toppings;
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
      SizeP = size;
      CrustP = crust;
      ToppingsP.AddRange(toppings);
    }
    //finalizers/deconstructors
  }
}