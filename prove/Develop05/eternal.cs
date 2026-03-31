public class Eternal : Goal
{
    public Eternal(string name, string _description, int point, string type) : base(name, _description, point, type)
    {

    }
    public override string SaveGoal()
    {
        return $"{GetGoalType()}|{GetName()}|{GetDescription()}|{GetPoints()}|{GetStatus()}";
    }
}