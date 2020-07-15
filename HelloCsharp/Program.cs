using System;

namespace HelloCsharp
{
  class Program
  {
    static void Main()
    {
      Console.Write("Enter FirstName: ");
      var firstName = Console.ReadLine();
      Console.Write("Enter LastName: ");
      string lastName = Console.ReadLine();

      Console.WriteLine("{0} {1}", firstName, lastName);

      Console.ReadLine();
    }
  }
}