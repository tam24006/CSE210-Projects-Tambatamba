using System.Xml.Linq;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _point;
    protected string _goalType;
    protected bool _isCompleted = false;

    public Goal(string name, string description, int point, string type)
    {
        _name = name;
        _description = description;
        _point = point;
        _goalType = type;
    }
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");

    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _point;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    public virtual bool GetStatus()
    {
        return _isCompleted;
    }
    public abstract string SaveGoal();
    public virtual void ResetGoal()
    {

    }
    public virtual int RecordEvent()
    {
        return _point;
    }
}