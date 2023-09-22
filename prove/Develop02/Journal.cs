public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void ReadFromFile(string journalFileName)
    {
        string[] lines = System.IO.File.ReadAllLines(journalFileName);
        foreach (string line in lines)
        {
            
            string[] parts = line.Split("|");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._entryText = parts[2];
            _entries.Add(newEntry);
        }
    }
    

    public void WriteToFile(string journalFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(journalFileName))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entryText}");
            }
        }
    }
    public void Display()
    {
         Console.WriteLine();
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
}