abstract class Goal
{
    private string _shortName;
    private string _description;
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

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        return (
            $"[{(IsComplete() ? "X" : " ")}]"
            + $" {_shortName} ({_description})"
        );
    }
}