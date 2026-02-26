
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry>_entries = new List<Entry>();
    public List<string> _prompts = new List<string>();
    public int _entryCounter;
    public string _latestupdate;

    public void DisplayJournal() {
        for (int i =0; i < _entries.Count; i++)
        {
            Entry entry = _entries[i];
            Console.WriteLine($"Entry {i + 1}:");
            entry.DisplayEntry();
        }
    }
    public void DisplayExtrainfor()
    {
        Console.WriteLine($"Number of entries: {CountEntry()}");
        Console.WriteLine($"Latest update: {FindLatesUpdate()}");
    }

    // how to save journal entries to a file and how to load the file and read the content of the file and display it in the console
    public void save()

    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        if (!filename.EndsWith(".txt"))
        {
            filename += ".txt";
        }
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }

    // how to load the file and read the content of the file and display it in the console
    public void Display()
    {
        Console.WriteLine("what is the filename? ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(filename);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length == 3)
            {
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _prompt = parts[1],
                    _response = parts[2]
                };
                _entries.Add(entry);

               
            }
        }

    }

    //write new entries to the file

    public void Write()
    {
        DateTime currentTime = DateTime.Now;
        string entryDate = currentTime.ToString("yyyy-MM-dd HH:mm:ss");
        string prompt = _prompts[new Random().Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt} - Date: {entryDate}");
        string response = Console.ReadLine();

        Entry entry = new Entry();
        entry._date = entryDate;
        entry._prompt = prompt;
        entry._response = response;

        _entries.Add(entry);


    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);

        string randomPrompt = _prompts[i];
        return randomPrompt;
    }

    public int CountEntry()
    {
        _entryCounter = _entries.Count;
        return _entryCounter;
    }

    public string FindLatesUpdate()
    {
        DateTime latestUpdate = DateTime.MinValue;
        foreach (Entry entry in _entries)
        {
            DateTime entryDate = DateTime.Parse(entry._date);
            if (entryDate > latestUpdate)
            {
                latestUpdate = entryDate;
            }
        }
        return latestUpdate.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public void Edit()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to edit.\n");
            return;
        }

        DisplayJournal();
        Console.WriteLine("Enter the number of the entry you want to edit: ");
        int answer = int.Parse(Console.ReadLine());

        if (answer < 1 || answer > _entries.Count)
        {
            Console.WriteLine("Invalid entry number.\n");
            return;
        }
        else {
            Entry entryToEdit = _entries[answer - 1];
            Console.WriteLine($"Current response: {entryToEdit._response}");
            Console.WriteLine("Enter new response: ");
            string newResponse = Console.ReadLine();
            entryToEdit._response = newResponse;
        }
    }

}   

