class Cycling : Activity
{
    private double _speed; //km per hour
    public Cycling(string name, double duration, double speed) : base(name, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _duration / 60 * _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _duration / GetDistance(); // min per km
    }
}