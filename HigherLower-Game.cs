using System;

public class HigherLowerGame
{

  public static void Main()
  {
    bool keepPlaying = true;
    int guess = 0;
    int min = 1;
    int max = 100;

    Console.WriteLine("Would you like to play the higher/lower game? (Yes/No)");
    string userInput = Console.ReadLine();

    if(userInput == "Yes")
    {
      Random rand = new Random();
      Console.WriteLine("Okay, lets play. Pick a number between 1 and 100.");
      while(keepPlaying)
      {
        guess = rand.Next(min, max);
        Console.WriteLine("Is your number higher or lower than " + guess + "? (Higher/Lower/Correct)");
        userInput = Console.ReadLine();

        if(userInput == "Higher")
        {
          min = guess+1;
        }
        else if(userInput == "Lower")
        {
          max = guess-1;
        }
        else if(userInput == "Correct")
        {
          Console.WriteLine("Great! I guessed your number. Would you like to play again? (Yes/No)");
          userInput = Console.ReadLine();
          if(userInput == "Yes")
          {
          min = 1;
          max = 100;
          }
          else
          {
            keepPlaying = false;
            Console.WriteLine("Goodbye.");
          }
        }
      }
    }
    else 
    {
      Console.WriteLine("Goodbye.");
    }
  }

}

/*
  guess

  while guess is incorrect and user wants to play again
    ask higher/lower/correct
    if correct, ask to play again
    if higher, new max = guess
    if lower, new min = guess

    guess again between min/max
*/