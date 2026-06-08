using System.Diagnostics;
using System.Text;

class ListingActivity : Activity
{
    private static readonly string[] _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    ];

    public ListingActivity(int duration) : base(duration)
    {
        _name = "Listing";
        _description = (
            "This activity will help you reflect on the good things in your life"
            + " by having you list as many things as you can in a certain area"
        );
        
    }

    private static void DisplayPrompt()
    {
        Console.WriteLine(_prompts[Program.random.Next(_prompts.Length)]);
        // Bubble growing and popping animation
        ShowCountDown(5);
    }

    private List<string> CollectItems(int duration)
    {
        List<string> items = [];
        Stopwatch stopwatch = new();
        stopwatch.Start();
        StringBuilder builder = new();
        Console.WriteLine($"Type as many items as you can in {_duration} seconds:");

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        if (builder.Length > 0)
                        {
                            items.Add(builder.ToString());
                            builder = new();
                            Console.Write("\n");
                        }
                        break;
                    case ConsoleKey.Backspace:
                        if (builder.Length > 0)
                        {
                            builder.Remove(builder.Length - 1, 1);
                            Console.Write("\b \b");
                        }
                        break;
                    default:
                        builder.Append(key.KeyChar);
                        Console.Write(key.KeyChar);
                        break;
                }
            }
            Thread.Sleep(50); // ms
        }
        if (builder.Length > 0)
        {
            builder.Append("...");
            items.Add(builder.ToString());
            Console.WriteLine();
            Console.WriteLine();
        }
        return items;
    }

    private static void FlushInputBuffer()
    {
        while (Console.KeyAvailable)
        {
            Console.ReadKey(true);
        }
    }

    public override void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        List<string> items = CollectItems(_duration);
        Console.WriteLine($"You entered {items.Count} items!");
        DisplayEndingMessage();
        FlushInputBuffer();
    }
}