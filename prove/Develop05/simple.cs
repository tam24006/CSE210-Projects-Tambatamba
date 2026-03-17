public class simple : goal
{
    public simple(string name, string _description, int point, string type) : base(name, _description, point, type)
    {

    }
    public override void DisplayGoal()
    {
        if (_isCompleted == false)
        {
            base.DisplayGoal();
        }
        else
        {
            Console.WriteLine($"[X] {_name} ({_description})");
        }

    }
    public override bool GetStatus()
    {
        return _isCompleted;
    }
    public string GetStatusString()
    {
        if (_isCompleted)
        {
            return "True";
        }
        else
        {
            return "False";
        }
    }
    public void SetStatus(bool status)
    {
        _isCompleted = status;
    }
    public override string SaveGoal()
    {
        return $"{GetGoalType()}|{GetName()}|{GetDescription()}|{GetPoints()}|{GetStatusString()}";
    }
    public override int RecordEvent()
    {
        _isCompleted = true;
        return base.RecordEvent();
    }
    public override void ResetGoal()
    {
        _isCompleted = false;
    }
}
