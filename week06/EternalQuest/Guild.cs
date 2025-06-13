class Guild
{
    private string _name;
    private string _description;
    private List<Goal> _goals;

    public Guild(string name, string description)
    {
        _name = name;
        _description = description;
        _goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDisplayString()
    {
        string goalString = "";
        foreach (Goal goal in _goals) goalString += $" -{goal.GetName()}\n";
        return $"Guild of {_name}s\nDescription: {_description}\nGoals:\n{goalString}";
    }

    public int GetLevel()
    {
        int topScore = 0;
        int playerScore = 0;
        foreach (Goal goal in _goals)
        {
            topScore += goal.GetPoints();
            if (goal.IsComplete()) playerScore += goal.GetPoints();
        }
        int level = playerScore / topScore * 20;
        return level;
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }


}