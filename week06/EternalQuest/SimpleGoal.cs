class SimpleGoal() : Goal
{
    private bool _isComplete = false;

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        Console.WriteLine("That goal is already complete.");
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return "TBI";
    }
}