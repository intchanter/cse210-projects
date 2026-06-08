class BreathingActivity : Activity
{

    public BreathingActivity(int duration) : base(duration)
    {
        _name = "Breathing";
        _description = (
            "This activity will help you relax by walking you through breathing in"
            + " and out slowly. Clear your mind and focus on your breathing."
        );

    }

    public override void Run()
    {
        DisplayStartingMessage();
        // Breathing animation
        int seconds = _duration;
        int inhale = 4;
        int exhale = 5;
        while (seconds > 0)
        {
            if (inhale > seconds)
            {
                inhale = seconds;
            }
            Console.WriteLine("Breathe in...");
            ShowCountDown(inhale);
            seconds -= inhale;
            
            if (exhale > seconds)
            {
                exhale = seconds;
            }
            Console.WriteLine("Breathe out...");
            ShowCountDown(exhale);
            seconds -= exhale;
        }
        DisplayEndingMessage();
    }
}