abstract class Activity
{
    protected DateTime _date;
    protected string _name;
    protected double _duration; //in minutes
    public Activity(string name, double duration)
    {
        _date = DateTime.Now;
        _name = name;
        _duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.Date} {_name} ({_duration} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km.";
    } 
}