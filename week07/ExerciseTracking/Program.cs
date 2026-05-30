class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = [
            new Running("2026-03-22", 35, 2),
            new Cycling("2026-03-23", 40, 10),
            new Swimming("2026-03-24", 30, 7),
        ];

        Console.Clear();

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}