public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, string street, string city, string state, string country, string speaker, int capacity) : base(title, description, date, time, street, city, state, country)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }

    public override string GetFullDetails()
    {
       string details = base.GetStandardDetails() + "\nSpeaker: " + _speaker + "\nCapacity: " + _capacity;
       return details;
    }

    public override string GetShortDescription()
    {
        string details = "Lecture Event\n" + base._eventTitle + "\n" + base._date;
        return details;
    }
}