using System;

public class HigherLowerGame
{

  public static void Main()
  {
    // bool keepPlaying = true;
    // int guess = 0;
    // int min = 1;
    // int max = 100;

    // Console.WriteLine("Would you like to play the higher/lower game? (Yes/No)");
    // string userInput = Console.ReadLine();

    // if(userInput == "Yes")
    // {
    //   Random rand = new Random();
    //   Console.WriteLine("Okay, lets play. Pick a number between 1 and 100.");
    //   while(keepPlaying)
    //   {
    //     guess = rand.Next(min, max);
    //     Console.WriteLine("Is your number higher or lower than " + guess + "? (Higher/Lower/Correct)");
    //     userInput = Console.ReadLine();

    //     if(userInput == "Higher")
    //     {
    //       min = guess+1;
    //     }
    //     else if(userInput == "Lower")
    //     {
    //       max = guess-1;
    //     }
    //     else if(userInput == "Correct")
    //     {
    //       Console.WriteLine("Great! I guessed your number. Would you like to play again? (Yes/No)");
    //       userInput = Console.ReadLine();
    //       if(userInput == "Yes")
    //       {
    //       min = 1;
    //       max = 100;
    //       }
    //       else
    //       {
    //         keepPlaying = false;
    //         Console.WriteLine("Goodbye.");
    //       }
    //     }
    //   }
    // }
    // else 
    // {
    //   Console.WriteLine("Goodbye.");
    // }

    string userInput;
    bool keepPlaying = true;
    bool correct = false;
    int min = 1;
    int max = 100;
    int guess;
    Random rand = new Random();

    while(keepPlaying)
    {
      Console.WriteLine("Do you want to play version 1(computer guesses) or version 2(you guess)? (1/2)");
      userInput = Console.ReadLine();

      if(userInput == "1")
      {
        while(!correct)
        {
          guess = rand.Next(min, max);
          Console.WriteLine("Is your number higher or lower than " + guess + "? (Higher/Lower/Correct)");
          userInput = Console.ReadLine();
          if(userInput == "Higher")
          {
            min= guess+1;
          }
          else if(userInput == "Lower")
          {
            max = guess-1;
          }
          else if(userInput == "Correct")
          {
            correct = true;
          }
        }
        Console.WriteLine("Great! I guessed your number. Would you like to play again? (Yes/No)");
        userInput = Console.ReadLine();
        if(userInput == "No")
        {
          keepPlaying = false;
          Console.WriteLine("Goodbye.");
        }
        else
        {
          correct = false;
          min = 1;
          max = 100;
        }
      }
      else
      {
        // Version 2, computer picks number and user guesses
        int compNum = rand.Next(min, max);
        Console.WriteLine("I have picked a number between " + min + " and " + max + ".");
        while(!correct)
        {
          Console.WriteLine("What is your guess?");
          int userGuess = int.Parse(Console.ReadLine());
          if(userGuess == compNum)
          {
            correct = true;
          }
          else if(userGuess > compNum)
          {
            Console.WriteLine("Your guess was higher than my number.");
          }
          else
          {
            Console.WriteLine("Your guess was lower than my number.");
          }
        }
        Console.WriteLine("You guessed my number! Would you like to play again? (Yes/No)");
        userInput = Console.ReadLine();
        if(userInput == "Yes")
        {
          min = 1;
          max = 100;
          keepPlaying = true;
        }
        else
        {
          keepPlaying = false;
          Console.WriteLine("Goodbye.");
        }
      }
    }
  }
}
/*
  while user wants to play
    ask which version
    if version 1

      while guess not correct
        guess between min/max
        ask higher/lower/correct
        if higher, new max = guess
        if lower, new min = guess
      
      ask if user wants to play again

    else version 2
      computer picks number
      while guess not correct
        if guess higher than number tell user
        if guess lower than number tell user

      guess correct, ask if user wants to play again

*/