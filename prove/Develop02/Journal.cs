public class Journal
{

    private List<Entry> _entries = new List<Entry>();
    
    public string _name = "";

    public Journal()
    {

    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void NewEntry(string entered_prompt)
    {
        Prompt prompts = new Prompt();
        Entry newEntry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        newEntry._date = theCurrentTime.ToShortDateString();
        newEntry._prompt = entered_prompt;
        Console.WriteLine(entered_prompt);
        Console.Write("> ");
        newEntry._input = Console.ReadLine();

        _entries.Add(newEntry);
    }

    public void Save()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._prompt);
                outputFile.WriteLine(entry._input);
            }    
        }
    }

    public void Load()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _entries.Clear();

        for (int i = 0; i < lines.Count(); i += 3)
        {
            Entry loadEntry = new Entry(); 
            loadEntry._date = lines[i];
            loadEntry._prompt = lines[i+1];
            loadEntry._input = lines[i+2];
            
            _entries.Add(loadEntry);
        }
    }    
}