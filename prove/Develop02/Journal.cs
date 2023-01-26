using System;
using System.IO;
class Journal
{
    public List<Entry> _entryList = new List<Entry> {};

    public Journal()
    {

    }

    public void displayJournal()
    {
        foreach (Entry entry in _entryList)
        {
            entry.display();
        }
    }

    public void addEntry(Entry entry)
    {
        _entryList.Add(entry);
    }

    public void loadFile(string filename)
    {

    }

    public void saveFile(string filename)
    {
        
    }
}