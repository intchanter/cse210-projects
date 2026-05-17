using System.ComponentModel;
using System.Xml.Linq;

class Journal
{
    private List<Entry> _entries = new();

    public void SaveToFile(string filename)
    {
        using (StreamWriter outFile = new(filename))
        {
            foreach (Entry entry in _entries)
            {
                outFile.WriteLine(Entry.Format(entry));
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries = new();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Entry entry = Entry.Parse(line);
            AddEntry(entry);
        }
    }

    public void AddEntry(Entry entry)
    {
        Console.WriteLine("AddEntry()");
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("DisplayAll()");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}