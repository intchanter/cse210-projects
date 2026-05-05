using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        float grade = Input.Float("What is your grade percentage? ");

        Console.WriteLine(LetterGrade(grade));

        if (Pass(grade))
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }
            
    }

    static bool Pass(float grade)
    {
        return grade >= 70;
    }

    static string LetterGrade(float grade)
    {
        string letterGrade;
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (letterGrade != "F")
        {
            float fraction = grade % 10;

            if (fraction >= 7 && letterGrade != "A")
            {
                letterGrade += "+";
            }
            else if (fraction < 3)
            {
                letterGrade += "-";
            }
        }
        return letterGrade;
    }
}

class Input
{
    public static string String(string prompt = "")
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    public static int Integer(string prompt = "")
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    public static float Float(string prompt = "")
    {
        Console.Write(prompt);
        return float.Parse(Console.ReadLine());
    }
}