class Prompt 
{
    //Attributes
    public List<string> _promptList = new List<string> 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    //Constructor
    public Prompt()
    {

    }

    public string generatePrompt()
    {
        Random randomNumber = new Random();
        string prompt = _promptList[randomNumber.Next(5)];
        return prompt;
    }
}