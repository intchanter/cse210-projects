using System;

class Program
{
    static void Main(string[] args)
    {
        string first = Input("What is your first name? ");
        string last = Input("What is your last name? ");
        Console.WriteLine($"\nYour name is {last}, {first} {last}.");
    }

    static string Input(string prompt = "")
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}