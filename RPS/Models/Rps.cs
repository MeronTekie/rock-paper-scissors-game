using System;

namespace Rps.Models
{
  public class Rock
  {

    public string Game( string Player1, string Player2)
    {
      if(Player1 == Player2)
      {
        return "It's a draw";
      }
      else if ((Player1 == "Rock" && Player2 == "Scissors") || (Player1 =="Scissors" && Player2 =="Paper") || (Player1 == "Paper" && Player2 =="Rock"))
      {
        return "Player 1 is the winner";
      }
      else
      {
        return "Player 2 is the winner";
      }
    }
  }
}