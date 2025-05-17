using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    // Create a new entry
    public void NewEntry()
    {
        Entry entry = new Entry();
        entry.GenerateDate();
        entry.GeneratePrompt();
        entry.GetResponse();
        entries.Add(entry);
    }

    // Display all journal entries
    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.ShowEntry();
            Console.WriteLine();
        }
    }

    // Save entries to a file
    public void SaveEntries(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.date}|{entry.prompt}|{entry.response}");
            }
        }
    }

    // Load entries from a file
    public void LoadEntries(string filename)
    {
        entries.Clear();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry();
                    entry.date = parts[0];
                    entry.prompt = parts[1];
                    entry.response = parts[2];
                    entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
