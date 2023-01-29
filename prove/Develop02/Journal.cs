using System;
using System.IO;

class Journal
{
    public List<Entry> _entryList = new List<Entry> {};

    public Journal()
    {

    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entryList)
        {
            entry.Display();
        }
    }

    public void AddEntry(Entry entry)
    {   
        _entryList.Add(entry);
    }

    public void LoadFile(string filename)
    {
        try 
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];


                Entry entry = new Entry(date, prompt, response);

                _entryList.Add(entry);
            }
        } catch (FileNotFoundException e)
        {
            Console.WriteLine($"File not found!", e.Message);
        }

    }

    public void SaveFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entryList) {
                string entryLine = entry.ConvertString();
                outputFile.WriteLine(entryLine);
            }
            
        }
    }
}