public class Manager
{
    private List<Goal> _goals = new List<Goal>();
    private List<Goal> _completedGoals= new List<Goal>();
    private int _totalPoints = 0;

    public Manager(List<Goal> goals)
    {
        _goals = goals;
    }

    public void DisplayPoint()
    {
        Console.WriteLine($"\nYou have {_totalPoints} points.\n");
    }

    public void CreateNewGoal()
    {
        Console.Write("The types of Goals are: \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal \nWhich type of goal would you like to create? ");
        string answer = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string pointStr = Console.ReadLine();
        int point = int.Parse(pointStr);


        if (answer == "1")
        {
            Simple sg = new Simple(name, description, point, "Simple Goal");
            _goals.Add(sg);
        }
        else if (answer == "2")
        {
            Eternal eg = new Eternal(name, description, point, "Eternal Goal");
            _goals.Add(eg);

        }
        else if (answer == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string time = Console.ReadLine();
            int timeToComplete = int.Parse(time);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonus = Console.ReadLine();
            int bonusPoint = int.Parse(bonus);

            ChecklistActivity cg = new ChecklistActivity(timeToComplete, bonusPoint, name, description, point, "Checklist Goal");
            _goals.Add(cg);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
    public void ListGoals()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].DisplayGoal();
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        if (!filename.EndsWith(".txt"))
        {
            filename += ".txt";
        }
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.SaveGoal());
            }
        }

    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the filename of the goal file? ");
        string filename = Console.ReadLine();

        if (!filename.EndsWith(".txt"))
        {
            filename += ".txt";
        }

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(filename);

        _goals.Clear();

        // total point
        string pointstr = lines[0].Trim();
        _totalPoints = int.Parse(pointstr);

        // goals
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            string goalType = parts[0].Trim();
            string name = parts[1].Trim();
            string description = parts[2].Trim();
            int point = int.Parse(parts[3].Trim());

            if (goalType == "Simple Goal")
            {
                bool status = bool.Parse(parts[4].Trim());
                Simple sg = new Simple(name, description, point, "Simple Goal");
                sg.SetStatus(status);
                _goals.Add(sg);
            }
            else if (goalType == "Eternal Goal")
            {
                Eternal eg = new Eternal(name, description, point, "Eternal Goal");
                _goals.Add(eg);
            }
            else
            {
                int bonusPoint = int.Parse(parts[4].Trim());
                int timeToComplete = int.Parse(parts[5].Trim());
                int timeDone = int.Parse(parts[6].Trim());
                ChecklistActivity cg = new ChecklistActivity(timeToComplete, bonusPoint, name, description, point, "Checklist Goal");
                cg.SetTimeDone(timeDone);
                _goals.Add(cg);

            }

        }

    }
     public void RecordEvents()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        string answer = Console.ReadLine();
        int index = int.Parse(answer) - 1;

        Goal g = _goals[index];
        int pointEarned = g.RecordEvent();
        _totalPoints += pointEarned;

        Console.WriteLine($"Congratulations! You have earned {pointEarned} points!");
        Console.WriteLine($"You now have {_totalPoints} points.");
    }

    public void ResetGoals()
    {
        _completedGoals.Clear();

        foreach (Goal g in _goals)
        {
            if (g.GetStatus())
            {
                _completedGoals.Add(g);
            }
        }

        if (_completedGoals.Count == 0)
        {
            Console.WriteLine("There are no completed goals to reset.");
        }

        else
        {
            Console.WriteLine("\nCompleted goals:");
            for (int i = 0; i < _completedGoals.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {_completedGoals[i].GetName()}");
            }

            Console.Write("Which goal do you want to reset? ");
            string answer = Console.ReadLine();
            int index = int.Parse(answer) - 1;

            Goal g = _completedGoals[index];
            g.ResetGoal();
            Console.WriteLine($"Goal '{g.GetName()}' has been reset.");
        }


    }    
}