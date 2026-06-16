using System.Diagnostics.Tracing;

class GoalManager
{
    private List<Goal> _goals = [];
    private int _score = 0;

    public GoalManager()
    {
    }

    public void Start()
    {
        bool run = true;
        while (run)
        {
            DisplayMenu();
            string selection = Console.ReadLine();
            switch (selection.ToLower())
            {
                case "c":
                    CreateGoal();
                    break;

                case "d":
                    ListGoalDetails();
                    break;

                case "r":
                    RecordEvent();
                    break;

                case "s":
                    SaveGoals();
                    break;

                case "l":
                    LoadGoals();
                    break;

                case "q":
                    run = false;
                    break;

                default:
                    break;
            }
        }
    }

    void DisplayMenu()
    {
        int level = Level(_score);
        Console.Write(
            $"\nYou have {_score} points, and are level {Level(_score)}.\n"
            + $"You need {PointsToNextLevel(_score, level + 1)} more points"
            + $" to reach level {level + 1}.\n\n"
            + "Please make your selection:\n\n"
            + "(C)reate a new goal\n"
            + "(D)isplay your goals\n"
            + "(R)ecord a completion\n"
            + "(S)ave your goals\n"
            + "(L)oad your goals\n"
            + "(Q)uit\n"
            + "> "
        );
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine($"\nYou have {_goals.Count} goals:\n");

        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}: {goal.GetDetailsString()}");
            index++;
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Goal goal = null;
        while (goal == null)
        {
            Console.Write(
                "Which type of goal would you like to create?\n"
                + "(S)imple\n"
                + "(E)ternal\n"
                + "(C)hecklist\n"
                + "> "
            );

            string goalType = Console.ReadLine();

            switch (goalType.ToLower())
            {
                case "s":
                    goal = new SimpleGoal();
                    break;

                case "e":
                    goal = new EternalGoal();
                    break;

                case "c":
                    goal = new ChecklistGoal();
                    break;

                default:
                    break;
            }
        }
        _goals.Add(goal);
    }

    public void RecordEvent()
    {
        if (_goals.Count < 1)
        {
            Console.WriteLine("No goals for which to record an event.");
            return;
        }

        int selection;
        while (true)
        {
            Console.Write("Which goal number did you do? ");
            try
            {
                selection = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error parsing selection.");
                continue;
            }

            if (selection < 1 || selection > _goals.Count)
            {
                Console.WriteLine("Goal selection out of range.");
                continue;
            }
            break;
        }
        int points = _goals[selection - 1].RecordEvent();
        if (points > 0)
        {
            Console.WriteLine($"You earned {points} points.");
        }
        _score += points;
    }

    public void SaveGoals()
    {
        Console.Write("What filename would you like to write to? ");
        string filename = Console.ReadLine();

        using StreamWriter stream = new(filename);
        stream.WriteLine(System.Text.Json.JsonSerializer.Serialize(_score));
        foreach (Goal goal in _goals)
        {
            stream.WriteLine(Goal.Format(goal));
        }
    }

    public void LoadGoals()
    {
        StreamReader stream;

        Console.Write("What filename would you like to read from? ");
        string filename = Console.ReadLine();

        try
        {
            stream = new(filename);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No such file: {filename}");
            return;
        }

        string firstLine = stream.ReadLine();
        _score = System.Text.Json.JsonSerializer.Deserialize<int>(firstLine);

        _goals = [];
        while (stream.Peek() >= 0)
        {
            Goal goal = Goal.Parse(stream.ReadLine());
            _goals.Add(goal);
        }
    }

    public static int Level(int score)
    {
        // The level will be determined by the previous Triangle(N) multiple of 100
        // https://math.stackexchange.com/questions/2319295/find-n-from-a-random-number-rounded-up-to-nearest-triangle-number
        return (int) Math.Floor((Math.Sqrt(8.0f * (score / 100.0f) + 1) - 1) / 2);

    }

    public static int PointsToNextLevel(int score, int nextLevel)
    {
        return (int) Math.Floor(nextLevel * (nextLevel + 1) / 2.0f) * 100 - score;
    }
}