using System;
using System.Buffers;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        List<goal> goals = new List<goal>();
        Manager gm = new Manager(goals);

        while (running)
        {
            gm.DisplayPoints();
            Console.Write("Please select one of the following choices: \n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Exit\n");
            if (option == "1")
            {
                gm.CreateNewGoal();

            }
            else if (option == "2")
            {
                gm.ListGoals();
            }
            else if (option == "3")
            {
                gm.SaveGoals();
            }
            else if (option == "4")
            {
                gm.LoadGoals();
            }
            else if (option == "5")
            {
                gm.RecordEvent();
            }
            else if (option == "6")
            {
                running = false;
            }
            else 
            {
                Console.WriteLine("Invalid option. Please try again.");
            }

         }

    }
}