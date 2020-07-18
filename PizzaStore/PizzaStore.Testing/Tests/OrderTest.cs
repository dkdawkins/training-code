using System.Collections.Generic;
using PizzaStore.Domain.Models;
using Xunit;

namespace PizzaStore.Testing.Tests
{
    public class OrderTest
    {
      [Theory]
      [InlineData("S", "C", "T")]
      [InlineData("S2", "C2", "T2")]

      public void Test_CreatePizza(string s, string c, string t)
      {
        //arrange
        var sut = new Order();
        string size = "S";
        string crust = "C";
        List<string> toppings = new List<string>{t};

        //act
        sut.CreatePizza(size, crust, toppings);

        //assert
        Assert.True(sut.Pizzas.Count == 1);

      }
    }
}