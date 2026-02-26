using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        Journal journal = new Journal();
        journal._entries = new List<Entry>();
        journal._entryCounter = 0;
        journal._latestupdate = "";
        journal._prompts = new List<string>
        {
            "What was the best part of your day?",
            "What are you grateful for today?",
            "What is something new you learned today?",
            "What is a challenge you faced today and how did you overcome it?",
            "What is something that made you happy today?"
        };

        while (running)
        {
            Console.Write("Please select one of the following choices: \n1. Write\n2. Display\n3. Save\n4. Load\n5. Exit\n");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                journal.Write();
            }
            else if (choice == "2")
            {
                journal.DisplayJournal();
                journal.DisplayExtrainfor();
            }
            else if (choice == "3")
            {
                journal.save();
            }
            else if (choice == "4")
            {
                journal.Display();
            }
            else if (choice == "5")
            {
                running = false;
            }
             else
            {
                Console.WriteLine("Invalid choice. Please try again.\n");
            }
        }

    }
}