public class Running : Activity
{
    private double _distance;

    public Running(int duration, string date, double distance) : base(duration, date)
    {
        this._distance = distance;
    }

    protected override double GetDistance()
    {
        return _distance; 
    }

    protected override double GetSpeed()
    {
        double speed = (_distance / base._duration) * 60;
        return speed;
    }

    protected override double GetPace() 
    {
        double pace = base._duration / _distance;
        return pace;
    }
}