using System;
using System.IO;
using System.Collections.Generic;


public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nYour journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (var entry in _entries)
                {
                    outputFile.WriteLine($"{entry.Date}|{entry.PromptText} | {entry.EntryText}");
                }
            }
            Console.WriteLine($"Journal entries saved to '{file}' successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine($"The file '{file}' does not exist.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }

        }
        Console.WriteLine($"Journal entries loaded from '{file}' successfully.");
    }
}

