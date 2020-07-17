using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
  public class Order
  {
    public List<Pizza> PizzasP { get; }

    public void CreatePizza(string size, string crust, List<string> toppings)
    {
      PizzasP.Add(new Pizza(size, crust, toppings));
    }

    public Order()
    {
      PizzasP = new List<Pizza>();
    }
  }
}