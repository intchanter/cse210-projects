using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        do
        {
            int magicNumber = randomGenerator.Next(1, 11);
            int guesses = 0;
            
            while (true)
            {
                int guess = Input.Integer("What is your guess? ");
                guesses += 1;
                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
            }
            Console.WriteLine($"You used {guesses} guesses");
        } while (Input.String("Would you like to play again? (y/n) ").ToLower() == "y");
    }
}

class Input
{
    static public int Integer(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToInt32(Console.ReadLine());
    }

    static public string String(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}