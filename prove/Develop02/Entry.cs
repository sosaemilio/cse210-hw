using System;
class Entry
{
    public string _prompt;
    public string _date;
    public string _response;


    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"\n{_date} - ({_prompt}) {_response}");
    }

    public string ConvertString()
    {
        string line = $"{_date} - ({_prompt}) {_response}";
        return line;
    }
}