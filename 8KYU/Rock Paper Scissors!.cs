// Rock Paper Scissors
// Let's play! You have to return which player won! In case of a draw return Draw!.

// Examples(Input1, Input2 --> Output):

// "scissors", "paper" --> "Player 1 won!"
// "scissors", "rock" --> "Player 2 won!"
// "paper", "paper" --> "Draw!"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
    public string Rps(string p1, string p2)
    {
        if (p1 == "rock" && p2 == "rock")
        {
            return "Draw!";
        }
        else if (p1 == "rock" && p2 == "paper")
        {
            return "Player 2 won!";
        }
        else if (p1 == "rock" && p2 == "scissors")
        {
            return "Player 1 won!";
        }

        if (p1 == "paper" && p2 == "rock")
        {
            return "Player 1 won!";
        }
        else if (p1 == "paper" && p2 == "paper")
        {
            return "Draw!";
        }
        else if (p1 == "paper" && p2 == "scissors")
        {
            return "Player 2 won!";
        }

        if (p1 == "scissors" && p2 == "rock")
        {
            return "Player 2 won!";
        }
        else if (p1 == "scissors" && p2 == "paper")
        {
            return "Player 1 won!";
        }
        else if (p1 == "scissors" && p2 == "scissors")
        {
            return "Draw!";
        }

        else
        {
            return "Please enter a rock, paper, or scissors";
        }
    }
}