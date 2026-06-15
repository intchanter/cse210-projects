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
                    Console.WriteLine("Save: To be implemented");
                    break;

                case "l":
                    Console.WriteLine("Load: To be implemented");
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
        Console.Write(
            $"\nYou have {_score} points.\n\n"
            + "Please make your selection:\n\n"
            + "(C)reate a new goal\n"
            + "(D)isplay your goals\n"
            + "(R)ecord a completion\n"
            + "Save your goals\n"
            + "Load your goals\n"
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
        Console.Write("Which goal number did you do? ");
        int selection = 0;
        while (true)
        {
            try
            {
                selection = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error parsing selection.");
            }
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

    }

    public void LoadGoals()
    {

    }
}