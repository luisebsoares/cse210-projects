public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete() => false;

    public override string GetStatus() => "[∞] " + _name;

    public override string SaveData()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }
}
