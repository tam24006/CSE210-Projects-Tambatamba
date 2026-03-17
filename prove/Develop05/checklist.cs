using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

public class checklistActivity : Activity
{
    private int _timeToComplete;
    private int _bonusPoints;
    private int _timeDone;

    public checklistActivity(string name, string description, int point, string type) : base(name, description, point, type)
    {
        _timeToComplete = timeToComplete;
        _bonusPoints = bonusPoints;
        _timeDone = 0;
    }
    public override void DisplayGoals()
    {
        if (_isCompleted == false)
        {
            Console.WriteLine($"[ ] {_name} ({_description}) - Currently completed: {_timeDone}/{_timeToComplete} times");
        }
        else
        {
            Console.WriteLine($"[X] {_name} ({_description}) - Completed: {_timeDone}/{_timeToComplete} times");
        }
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public int GetTimeToComplete()
    {
        return _timeToComplete;
    }
    public int GetTimeDone()
    {
        return _timeDone;
    }
    public override bool GetStatus()
    {
        return _isCompleted;
    }
    public void SetTimeDone(int time)
    {
        _timeDone = time;
    }
    public override string SaveGoal()
    {
        return $"{GetGoalType()}|{GetName()}|{GetDescription()}|{GetPoints()}|{GetTimeToComplete()}|{GetBonusPoints()}|{GetTimeDone()}|{GetStatus()}";
    }
    public override int RecordEvent()
    {
        if (_isCompleted == false)
        {
            _timeDone++;

            if (_timeDone < _timeToComplete)
            {
                return _point;
            }
            else
            {
                _isCompleted = true;
                return _point + _bonusPoints;
            }
        }
    }
    public override void ResetGoal()
    {
        _timeDone = 0;
        _isCompleted = false;
    }

}