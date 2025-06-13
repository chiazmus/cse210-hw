class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        ++_amountCompleted;
        return _points + (IsComplete() ? _bonus : 0);
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetails()
    {
        return $"{base.GetDetails()} -- completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_target}|{_amountCompleted}|{_bonus}";
    }

}