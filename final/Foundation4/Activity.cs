public abstract class Activity
{
    private string _date;
    protected int _duration;

    public Activity(int duration, string date)
    {
        this._date = date;
        this._duration = duration;
    }


    protected abstract double GetDistance();
    protected abstract double GetSpeed();
    protected abstract double GetPace();
    public string GetSummary()
    {
        string summnary = $"{_date} " + GetType() + $" ({_duration} min) - Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per miles";
        return summnary;
    }
}