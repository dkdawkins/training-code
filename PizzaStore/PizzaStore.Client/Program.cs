using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      Welcome();
    }

    static void Welcome()
    {
      System.Console.WriteLine("Welcome to PizzaWorld");
      System.Console.WriteLine("Best Pizza in the World");
      System.Console.WriteLine();

      var startup = new PizzaStore.Client.Startup();
      var user = new User();
      var store = new Store();

      try
      {
        Menu(startup.CreateOrder(user, store));
      }
      catch(Exception ex)
      {
        System.Console.WriteLine(ex.Message);
      }
    }

    static void Menu(Order cart)
    {
      var exit = false;

      do
      {
        
        Startup.PrintMenu();

        int select;

        int.TryParse(Console.ReadLine(), out select);

        switch (select)
        {
          case 1:
            cart.CreatePizza("L", "Stuffed", new List<string>{"cheese"});
            System.Console.WriteLine("Cheese pizza added");
            break;
          case 2:
            cart.CreatePizza("L", "Stuffed", new List<string>{"pepperoni"});
            System.Console.WriteLine("Pepperoni pizza added");
            break;
          case 3:
            cart.CreatePizza("L", "Stuffed", new List<string>{"hawaiian"});
            System.Console.WriteLine("Hawaiian pizza added");
            break;
          case 4:
            cart.CreatePizza("L", "Stuffed", new List<string>{"custom"});
            System.Console.WriteLine("Custom pizza added");
            break;
          case 5:
            DisplayCart(cart);
            break;
          case 6:
            var fmw = new FileManager();
            fmw.Write(cart);
            System.Console.WriteLine("Thank you, goodbye!");
            exit = true;
            break;
          case 7:
            var fmr = new FileManager();
            DisplayCart(fmr.Read());
            break;
        }
      } while (!exit);
    }
    static void DisplayCart(Order cart)
    {
      foreach(var pizza in cart.Pizzas)
      {
        System.Console.WriteLine(pizza);
      }
    }
  }
}
