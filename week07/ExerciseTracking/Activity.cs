abstract class Activity
{
    private string _date;
    protected float _minutes;

    protected Activity(string date, float minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract float GetDistance();
    protected abstract string GetActivityType();

    public float GetPace()
    {
        return _minutes / GetDistance();
    }

    public float GetSpeed()
    {
        return GetDistance() * 60 / _minutes;
    }

    public string GetSummary()
    {
        return (
            $"{_date} {GetActivityType():N2}"
            + $" Distance: {GetDistance():N2} km"
            + $" Speed: {GetSpeed():N2} kph"
            + $" Pace: {GetPace():N2} min per km"
        );
    }
}