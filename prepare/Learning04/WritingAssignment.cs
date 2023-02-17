public class WritingAssignment : Assigment
{   
    private string _title;
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        this._title = title;
    }

    public void GetWritingInformation() 
    {
        Console.WriteLine($"{base.GetSummary()}");
        Console.WriteLine($"{_title} by {base._studentName}");
    }
}