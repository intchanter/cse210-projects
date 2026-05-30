class Swimming : Activity
{
    private float _laps;

    public Swimming(string date, float minutes, float laps) : base(date, minutes)
    {
        _laps = laps;
    }

    protected override string GetActivityType()
    {
        return "Swimming";
    }

    public override float GetDistance()
    {
        return _laps * 50 / 1000.0f;
    }
}