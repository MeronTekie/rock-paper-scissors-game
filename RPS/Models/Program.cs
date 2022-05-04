using System;
using System.Collections.Generic;
using Rps.Models;

namespace Rps
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Player one enter your choice:");
      string player1 = Console.ReadLine();
      Console.WriteLine("Player two enter your choice:");
      string player2 = Console.ReadLine();

      Rock winner = new Rock();

      Console.WriteLine(winner.Game(player1,player2));
    }
  }
}