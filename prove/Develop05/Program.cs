using System;
using System.Buffers;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        List<Goal> goals = new List<Goal>();
        Manager gm = new Manager(goals);

        while (running)
        {
            gm.DisplayPoint();

            Console.Write("Menu Option:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Reset a goal\n7. Quit\nselect a choice from the menu: ");
            string Option = Console.ReadLine();
            if (Option == "1")
            {
                gm.CreateNewGoal();
            }
            else if (Option == "2")
            {
                gm.ListGoals();
            }
            else if (Option == "3")
            {
                gm.SaveGoals();
            }
            else if (Option == "4")
            {
                gm.LoadGoals();
            }
            else if (Option == "5")
            {
                gm.RecordEvents();
            }
            else if (Option == "6")
            {
                gm.ResetGoals();
            }
            else if (Option == "7")
            {
                running = false;
            }
            else 
            {
                Console.WriteLine("Invalid input. \n");
             }
        }

    }   
}