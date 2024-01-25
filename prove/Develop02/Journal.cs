using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(file))
        {
            while (!reader.EndOfStream)
            {
                string[] entryData = reader.ReadLine().Split(',');
                Entry loadedEntry = new Entry
                {
                    _date = entryData[0],
                    _promptText = entryData[1],
                    _entryText = entryData[2]
                };
                _entries.Add(loadedEntry);
            }
        }
    }
}
