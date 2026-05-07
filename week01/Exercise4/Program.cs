using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of integers, type 0 when finished.");
        while (true)
        {
            int number = Input.Integer("Enter integer: ");
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }

        int sum = 0;
        int largest = int.MinValue;
        int smallest = int.MaxValue;
        foreach (int number in numbers)
        {
            sum += number;
            if (number < smallest && number > 0)
            {
                smallest = number;
            }
            if (number > largest)
            {
                largest = number;
            }
        }
        float mean = sum / (float) numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The mean is: {mean}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine($"The largest number is: {largest}");
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
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