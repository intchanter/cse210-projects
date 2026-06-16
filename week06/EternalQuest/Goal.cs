using System.Text.Json;
using System.Text.Json.Serialization;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "GoalType")]
[JsonDerivedType(typeof(SimpleGoal), "Simple")]
[JsonDerivedType(typeof(EternalGoal), "Eternal")]
[JsonDerivedType(typeof(ChecklistGoal), "Checklist")]
abstract class Goal
{
    [JsonInclude]
    private string _shortName;
    [JsonInclude]
    private string _description;
    [JsonInclude]
    protected int _points;

    public Goal()
    {
        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();

        Console.Write("Give a brief description: ");
        _description = Console.ReadLine();

        int points = -1;
        while (points == -1)
        {
            Console.Write("How many points is it worth? ");
            try
            {
                points = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Could not parse the number of points.");
            }
        }
        _points = points;
    }

    [JsonConstructor]
    public Goal(string _shortName, string _description, int _points)
    {
        this._shortName = _shortName;
        this._description = _description;
        this._points = _points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return (
            $"[{(IsComplete() ? "X" : " ")}]"
            + $" {_shortName} ({_description})"
        );
    }

    public static string Format(Goal goal)
    {
        return System.Text.Json.JsonSerializer.Serialize(goal);
    }

    public static Goal Parse(string goal)
    {
        return System.Text.Json.JsonSerializer.Deserialize<Goal>(goal);
    }
}