class Running : Activity
{
    private float _distance;  // km

    public Running(string date, float minutes, float distance) : base(date, minutes)
    {
        _distance = distance;
    }

    protected override string GetActivityType()
    {
        return "Running";
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetPace()
    {
        return _minutes / GetDistance();
    }

    public override float GetSpeed()
    {
        return GetDistance() * 60 / _minutes;
    }
}