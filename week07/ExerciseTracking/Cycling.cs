class Cycling : Activity
{
    private float _kph;

    public Cycling(string date, float minutes, float kph) : base(date, minutes)
    {
        _kph = kph;
    }

    protected override string GetActivityType()
    {
        return "Cycling";
    }

    public override float GetDistance()
    {
        return _kph * _minutes / 60.0f;
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