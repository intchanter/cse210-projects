using System;
using System.Data;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new();
        Fraction five = new(5);
        Fraction twoFifths = new(2, 5);
        Console.WriteLine($"One: {one.GetFractionString()} or {one.GetDecimalValue()}");
        Console.WriteLine($"Five: {five.GetFractionString()} or {five.GetDecimalValue()}");
        Console.WriteLine($"Two Fifths: {twoFifths.GetFractionString()} or {twoFifths.GetDecimalValue()}");
    }
}