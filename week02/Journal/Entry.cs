using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Xml.Linq;

class Entry
{
    private static string _delimiter = "\e";
    public DateTime _date;
    public string _prompt;
    public string _response;

    public void Display()
    {
        Console.WriteLine($"Date: {_date:yyyy-MM-dd}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    public static string Format(Entry e)
    {
        return $"{e._date}\e{e._prompt}\e{e._response}";
    }

    public static Entry Parse(string s)
    {
        Entry entry = new();
        Console.WriteLine(s);
        string[] parts = s.Split(_delimiter);
        entry._date = DateTime.Parse(parts[0]);
        entry._prompt = parts[1];
        entry._response = parts[2];
        return entry;
    }
}