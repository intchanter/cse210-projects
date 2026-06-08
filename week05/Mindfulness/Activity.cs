abstract class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration;  // seconds

    public Activity(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great job!");
        // Bouncing animation
        ShowSpinner(2, "'-,-'", 0.2f);
        Console.WriteLine(
            $"Activity: {_name}\n"
            + $"Time: {_duration}\n"
        );
        ShowSpinner(5, "'-,-'", 0.2f);
    }

    public abstract void Run();

    public static void ShowSpinner(int seconds, string symbols, float delay)
    {
        float ticks = seconds / delay;
        int symbol = 0;
        while (ticks > 0)
        {
            // I'm not super positive the extra \b and space are necessary, but
            // they're included in case they're needed for a platform different
            // from my Ubuntu Linux system. Maybe the Windows terminal?
            Console.Write($"\b \b{symbols[symbol]}");
            symbol++;
            if (symbol >= symbols.Length)
            {
                symbol = 0;
            }
            ticks--;
            Thread.Sleep((int)(delay * 1000)); // ms
        }
        Console.Write("\b \b");
    }

    public static void ShowCountDown(int seconds)
    {
        while (seconds > 0)
        {
            string secondsText = $"{seconds}";
            Console.Write(secondsText);
            Thread.Sleep(1000); // ms
            Console.Write(
                new string('\b', secondsText.Length)
                + new string(' ', secondsText.Length)
                + new string('\b', secondsText.Length)
            );
            seconds--;
        }
    }
}