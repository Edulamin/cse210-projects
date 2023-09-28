using System;

class Program
{
    static void Main(string[] args)
    {   
        
        string repeat = "yes";

        while (repeat == "yes")
        {          
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int numberGuess = -1;
        int guessCount = 0;

            while (numberGuess != magicNumber)
            {
                Console.Write("Guess the magic number: ");
                numberGuess = int.Parse(Console.ReadLine());
                guessCount ++;
                
                if (numberGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (numberGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }                
            else
            {
                Console.WriteLine("You guessed the number");
                Console.WriteLine($"It took {guessCount} guesses!");
            }

            }
            Console.Write("Do you want to play again? ");
            repeat = Console.ReadLine();
        }  
    }
}