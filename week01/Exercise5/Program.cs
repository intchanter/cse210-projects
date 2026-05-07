using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        return Input.String("Please enter your name: ");
    }

    static int PromptUserNumber()
    {
        return Input.Integer("Please enter your favorite number: ");
    }
    
    static int SquareNumber(int number)
    {
        return number * number;
    }
    
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}

class Input
{
    public static int Integer(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    public static string String(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}