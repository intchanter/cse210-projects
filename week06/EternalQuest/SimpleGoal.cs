using System.Text.Json.Serialization;

class SimpleGoal : Goal
{
    [JsonInclude]
    private bool _isComplete = false;

    public SimpleGoal() : base()
    {
    }

    [JsonConstructor]
    public SimpleGoal(string _shortName, string _description, int _points, bool _isComplete) : base(_shortName, _description, _points)
    {
        this._isComplete = _isComplete;
    }

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
}