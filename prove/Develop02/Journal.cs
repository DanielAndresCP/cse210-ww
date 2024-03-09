using System.IO;
using System.Text.Json;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _fileDataSeparator = "*|*";


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no entries");
        }
        else
        {

            foreach (Entry entry in _entries)
            {
                Console.WriteLine("");
                entry.Display();
            }
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}{_fileDataSeparator}{entry._prompt}{_fileDataSeparator}{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string filename)
    {

        string[] lines = File.ReadAllLines(filename);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] data = line.Split(_fileDataSeparator);

            string date = data[0];
            string prompt = data[1];
            string entryText = data[2];

            Entry newEntry = new Entry();
            newEntry._date = date;
            newEntry._prompt = prompt;
            newEntry._entryText = entryText;

            AddEntry(newEntry);
        }
    }
}