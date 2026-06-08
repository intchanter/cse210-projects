// Enhancements:
// * Added polling for the ListingActivity to get characters one by one while
// there's time left for the activity.
// * Ensured the polling handles <backspace> and <enter> keys correctly.
// * Put ReflectionActivity's questions in a bag to avoid duplicates. Once
// they've all been used, the bag is refilled from the source.
// * Because the polling time can end while the user is still typing, added
// a method to flush the input buffer so the typed characters aren't
// left for the menu and other parts of the program to interpret.
// * Added "..." to the last item if it wasn't complete.
// * Ensured activity durations end at the specified time and don't overshoot.

class Program
{
    // This is a public member rather than a private one, so I've omitted
    // the leading underscore to indicate a public value. If this were a
    // bigger, more complicated program, I'd try something different like
    // creating a new class to hold the Random instance.
    public static readonly Random random = new();

    static void Main(string[] args)
    {
        char entry;
        bool quit = false;
        Type activityType = typeof(Activity);

        Console.Clear();
        while (!quit)
        {
            entry = Menu();

            switch (entry)
            {
                case 'b':
                    Console.WriteLine("Breathing Activity");
                    activityType = typeof(BreathingActivity);
                    break;
                case 'l':
                    Console.WriteLine("Listing Activity");
                    activityType = typeof(ListingActivity);
                    break;
                case 'r':
                    Console.WriteLine("Reflecting Activity");
                    activityType = typeof(ReflectingActivity);
                    break;
                case 'q':
                    quit = true;
                    continue;
                default:
                    continue;
            }

            int seconds = GetDuration();
            Activity activity = (Activity)Activator.CreateInstance(activityType, seconds);
            activity.Run();
        }
    }

    public static char Menu()
    {
        Console.Write(
            "Mindfulness options:\n\n"
            + "[B]reathing\n"
            + "[L]isting\n"
            + "[R]eflecting\n"
            + "[Q]uit\n"
            + "> "
        );
        char entry = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();
        return entry;
    }

    public static int GetDuration()
    {
        int seconds;
        while (true)
        {
            Console.Write("How long in seconds? ");
            try
            {
                seconds = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Error parsing number of seconds.");
            }
        }
        return seconds;
    }
}