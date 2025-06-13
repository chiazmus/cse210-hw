abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public int GetPoints()
    {
        return _points;
    }
    public string GetName()
    {
        return _name;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetails()
    {
        return $"[{(IsComplete() ? 'X' : ' ')}] {_name} ({_description})";
    }

    public abstract string GetStringRepresentation(); // For saving to a file
}