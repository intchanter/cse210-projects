using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Xml.Linq;

class Entry
{
    public DateTime _date { get; set; }
    public string _prompt { get; set; }
    public string _response { get; set; }

    public void Display()
    {
        Console.WriteLine($"Date: {_date:yyyy-MM-dd}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    public static string Format(Entry e)
    {
        return System.Text.Json.JsonSerializer.Serialize(e);
    }

    public static Entry Parse(string s)
    {
        return System.Text.Json.JsonSerializer.Deserialize<Entry>(s);
    }
}