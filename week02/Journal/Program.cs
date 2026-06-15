/*
 * Enhancement:
 *   Added the ability to select menu items with a letter
 *   Cleaned up the abstraction from the suggested structure by having
 *      journal class handle its I/O and the Entry class handle the formatting
 *      and parsing of individual entries.
 *   Updated the save and load functionality to use the JSONLines format
 */

class Program
{
    static PromptGenerator myPrompts = new();
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        string choice;
        bool exit = false;
        string filename;

        while (!exit)
        {
            choice = Menu();
            switch (choice) {
                case "w":
                case "1":
                    Entry myEntry = WriteEntry();
                    myJournal.AddEntry(myEntry);
                    break;

                case "d":
                case "2":
                    myJournal.DisplayAll();
                    break;

                case "s":
                case "3":
                    filename = Input.String("Please enter the name of the file to save: ");
                    myJournal.SaveToFile(filename);
                    break;

                case "l":
                case "4":
                    filename = Input.String("Please enter the name of the file to load: ");
                    myJournal.LoadFromFile(filename);
                    break;

                case "q":
                case "5":
                    exit = true;
                    break;
            }
        }
    }

    static string Menu()
    {
        List<string> menu = [
            "Please choose an option by number or letter:",
            "1. [W]rite",
            "2. [D]isplay",
            "3. [S]ave",
            "4. [L]oad",
            "5. [Q]uit",
        ];
        foreach (string line in menu)
        {
            Console.WriteLine(line);
        }
        return Console.ReadLine()[0..1];
    }

    static Entry WriteEntry()
    {
        Entry myEntry = new();
        myEntry._prompt = myPrompts.GetRandomPrompt();
        myEntry._date = DateTime.Now.Date;
        Console.WriteLine(myEntry._date);
        myEntry._response = Input.String(myEntry._prompt);
        myEntry.Display();
        return myEntry;
    }
}