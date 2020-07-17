using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
  public class Store
  {
    public List<Order> OrdersP { get; }

    public Store()
    {
      OrdersP = new List<Order>();
    }
  }
}