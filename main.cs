using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter temperature in Celsius");

    var input = Console.ReadLine();
    double celsius = Convert.ToInt32(input);

    var farenheit = ((celsius*9)/5+32);
   
    Console.WriteLine("Farenheit equivalent for " +celsius +" degree celsius is " +farenheit);

    if (farenheit < 32)
    {
      Console.WriteLine("This temperature is below freezing temperature of 32 degree farenheit");
    }
    if (farenheit > 212)
    {
      Console.WriteLine("This temperature is above boiling temperature of 212 degrees farenheit");
    }
  }
}