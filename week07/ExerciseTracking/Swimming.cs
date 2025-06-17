class Swimming : Activity
{
    private int _laps; //one lap is 50 meters
    public Swimming(string name, double duration, int laps) : base(name, duration)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50.0 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_duration / 60);
    }

    public override double GetPace()
    {
        return _duration / GetDistance();
    }

}