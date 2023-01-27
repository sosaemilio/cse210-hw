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
        //PENDING
    }

    public void SaveFile()
    {
        Console.WriteLine("Filename");
        string filename = Console.ReadLine();


        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entryList) {
                string entryLine = entry.ConvertString();
                outputFile.WriteLine(entryLine);
            }
            
        }
    }
}