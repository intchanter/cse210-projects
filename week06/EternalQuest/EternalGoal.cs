using System.Text.Json.Serialization;

class EternalGoal : Goal
{
    public EternalGoal() : base()
    {
    }

    [JsonConstructor]
    public EternalGoal(string _shortName, string _description, int _points) : base(_shortName, _description, _points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }
}