using System;
class Entry
{
    public string _prompt;
    public string _date;
    public string _response;


    public Entry(string date, string prompt, string response)
    {
        this._prompt = prompt;
        this._date = date;
        this._response = response;
    }

    public void Display()
    {
        Console.WriteLine($"\n{_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
    }

    public string ConvertString()
    {
        string line = $"{_date},{_prompt},{_response}";
        return line;
    }
}