using System.Text.Json.Serialization;

class ChecklistGoal : Goal
{
    [JsonInclude]
    private int _amountCompleted;
    
    [JsonInclude]
    private readonly int _target;
        
    [JsonInclude]
    private readonly int _bonus;

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

    [JsonConstructor]
    public ChecklistGoal(string _shortName, string _description, int _points, int _amountCompleted, int _target, int _bonus) : base(_shortName, _description, _points)
    {
        this._amountCompleted = _amountCompleted;
        this._target = _target;
        this._bonus = _bonus;
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

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} {_amountCompleted}/{_target}"; 
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
}