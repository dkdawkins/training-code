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

      //string[] cart2 = new string[3];

      //List<Pizza> cart5 = new List<Pizza>();
      //Menu(cart5);

      var startup = new PizzaStore.Client.Startup();
      var user = new User();
      var store = new Store();
      //var order = startup.CreateOrder(user, store);
      //Menu2(startup.CreateOrder(user, store));
      // if (order != null)
      // {
      //   Menu2(order);
      // }
      // else
      // {
      //   System.Console.WriteLine("technical difficulties");
      // }

      try
      {
        Menu2(startup.CreateOrder(user, store));
      }
      catch(Exception ex)
      {
        System.Console.WriteLine(ex.Message);
      }
    }

    // static void Menu(List<Pizza> cart)
    // {
    //   var exit = false;
    //   var number = 0;
    //   var startup = new PizzaStore.Client.Startup();

    //   do
    //   {
    //     if (number < 10)
    //     {
    //       System.Console.WriteLine("Select 1 for Cheese Pizza");
    //       System.Console.WriteLine("Select 2 for Pepperoni Pizza");
    //       System.Console.WriteLine("Select 3 for Hawaiian Pizza");
    //       System.Console.WriteLine("Select 4 for Custom Pizza");
    //       System.Console.WriteLine("Select 5 for Show Cart");
    //       System.Console.WriteLine("Select 6 for Exit");
    //       System.Console.WriteLine();

    //       int select;

    //       int.TryParse(Console.ReadLine(), out select);

    //       switch (select)
    //       {
    //         case 1:
    //           var p = startup.CreatePizza("L", "Stuffed", new List<string>{"cheese"});
    //           cart.Add(p);
    //           number += 1;
    //           System.Console.WriteLine("Cheese pizza added");
    //           break;
    //         case 2:
    //           cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"pepperoni"}));
    //           number += 1;
    //           System.Console.WriteLine("Pepperoni pizza added");
    //           break;
    //         case 3:
    //           cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"pineapple"}));
    //           number += 1;
    //           System.Console.WriteLine("Hawaiian pizza added");
    //           break;
    //         case 4:
    //           cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"custom"}));
    //           number += 1;
    //           System.Console.WriteLine("Custom pizza added");
    //           break;
    //         case 5:
    //           DisplayCart(cart);
    //           break;
    //         case 6:
    //           System.Console.WriteLine("Thank you, goodbye!");
    //           exit = true;
    //           break;
    //       }

    //     }
    //     else
    //     {
    //       DisplayCart(cart);
    //       exit = true;
    //     }
    //   } while (!exit);
    // }

    static void Menu2(Order cart)
    {
      var exit = false;

      do
      {
        
        System.Console.WriteLine("Select 1 for Cheese Pizza");
        System.Console.WriteLine("Select 2 for Pepperoni Pizza");
        System.Console.WriteLine("Select 3 for Hawaiian Pizza");
        System.Console.WriteLine("Select 4 for Custom Pizza");
        System.Console.WriteLine("Select 5 for Show Cart");
        System.Console.WriteLine("Select 6 for Exit");

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
            System.Console.WriteLine("Thank you, goodbye!");
            exit = true;
            break;
        }
      } while (!exit);
    }
    static void DisplayCart(Order cart)
    {
      foreach(var pizza in cart.PizzasP)
      {
        System.Console.WriteLine(pizza);
      }
    }
  }
}
