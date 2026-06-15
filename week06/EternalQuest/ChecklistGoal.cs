using System.Runtime.CompilerServices;

class ChecklistGoal : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;

    public ChecklistGoal() : base()
    {
        _amountCompleted = 0;

        Console.Write("How many times do you want to do it? ");
        int target = -1;
        while (target == -1)
        {
            try
            {
                target = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Could not parse the number of times.");
            }
        }
        _target = target;

        Console.Write("How many bonus points after all are complete? ");
        int bonus = -1;
        while (bonus == -1)
        {
            try
            {
                bonus = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Could not parse the number of bonus points.");
            }
        }
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine("That goal is already completed.");
            return 0;
        }
        
        _amountCompleted += 1;
        if (IsComplete())
        {
            Console.WriteLine($"You've earned a bonus {_bonus} points!");
            return _points + _bonus;
        }

        return _points;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}