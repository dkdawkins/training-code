using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
  public class User
  {
    public List<Order> OrdersP { get; } //Ensures the refernece can't change

    public User()
    {
      OrdersP = new List<Order>();
    }
  }
}