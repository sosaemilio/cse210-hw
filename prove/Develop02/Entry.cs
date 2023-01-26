using System;
class Entry
{
    public string _prompt;
    public string _date;
    public string _response;


    public Entry()
    {
    }

    public void display()
    {
        Console.WriteLine($"\n{_date} - ({_prompt}) {_response}");
    }
}