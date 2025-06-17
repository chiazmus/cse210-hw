class Running : Activity
{
    private double _distance;
    public Running(string name, double duration, double distance) : base(name, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (_duration / 60); // km/hour
    }

    public override double GetPace()
    {
        return _duration / _distance; // min per km
    }

}