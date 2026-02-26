using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        string[] lines = System.IO.File.ReadAllLines("scriptures.txt");
        Console.Write("start verse:");
        int startVerse = int.Parse(Console.ReadLine());

        Console.Write("end verse:");
        int endverse = int.Parse(Console.ReadLine());

        if (endverse > lines.Length)
        {
            Console.WriteLine("end verse is out of range");
            return;
        }
        else if (startVerse < 1)
        {
            Console.WriteLine($"Verse {startVerse} not available");
            return;
        }
        else if (startVerse > endverse)
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Reference reference1 = new Reference(" Nephi", "1", startVerse, endverse);
        string verse = GetverseFromReference(lines, reference1);
        Scriptures scriptures = new Scriptures(reference1, verse);

        while (isRunning)
        {
            scriptures.DisplayScripture();
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");
            string action = Console.ReadLine().Trim();
            if (action == "quit")
            {
                isRunning = false;
            }
            else if (action == "")
            {
                scriptures.HideRandomWord();
                Console.Clear();
            }

            else
            {
                Console.WriteLine("Invalid input. Please press Enter to hide a word or type 'quit' to exit.");
                return;
            }

            if (scriptures.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden.");
                isRunning = false;
            }
        }
    }

    static string GetverseFromReference(string[] lines, Reference reference)
    {
        int startVerse = reference.GetStartVerse();
        int endVerse = reference.GetEndVerse();
        List<string> verses = new List<string>();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            int verseNumber = int.Parse(parts[2]);
            string text = parts[3].Trim();

            if (verseNumber >= startVerse && verseNumber <= endVerse)
            {
                verses.Add(text);
            }
        }

        if (verses.Count == 0)
        {
            return "";
        }
        else
        {
            return string.Join(" ", verses);
        }
    }
}