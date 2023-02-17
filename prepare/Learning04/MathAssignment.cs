public class MathAssigment : Assigment
{
    private string _textbookSection;
    private string _problems;

    public MathAssigment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        this._problems = problems;
        this._textbookSection = textbookSection;
    }

    public void GetHomeworkList()
    {
        Console.WriteLine(base.GetSummary());
        Console.WriteLine($"{_textbookSection} {_problems}");
    }
}