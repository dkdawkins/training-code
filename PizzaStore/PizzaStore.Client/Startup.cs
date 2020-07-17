using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
  internal class Startup
  {
    internal Order CreateOrder(User user, Store store)
    {
      try
      {
        var order = new Order();

        user.OrdersP.Add(order);
        store.OrdersP.Add(order);

        return order;
      }
      catch
      {
        throw new System.Exception("we donked up");
        //return null;
      }
    }
  }
}