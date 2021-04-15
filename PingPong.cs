using System;
using System.Collections.Generic;

public class Program 
{
  public static void Main()
  {
    Console.WriteLine("Enter a number: ");
    string stringInputtedNumber = Console.ReadLine();
    int inputtedNumber = int.Parse(stringInputtedNumber);

    for (int index = 1; index <= inputtedNumber; index ++)
    {
      if (index % 3 == 0 && index % 5 == 0)
      {
        Console.WriteLine("ping-pong");
      }
      else if (index % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else if (index % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else
      {
        Console.WriteLine(index);
      }
    }
  }
}