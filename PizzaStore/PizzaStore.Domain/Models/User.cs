using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
  public class User
  {
    public List<Order> Orders { get; } //Ensures the refernece can't change

    public User()
    {
      Orders = new List<Order>();
    }
  }
}