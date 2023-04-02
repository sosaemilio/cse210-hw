public abstract class Event
{
    protected string _eventTitle;
    private string _description;
    protected string _date;
    private string _time;
    private Address _address;


    public Event(string title, string description, string date, string time, string street, string city, string state, string country)
    {
        this._eventTitle = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = new Address(street, city, state, country);
    }

    // Methods
    public string GetStandardDetails()
    {
        string details = _eventTitle + "\n" + _description + "\nDate: " + _date + "\nTime: "+ _time + "\nLocation: " + _address.GetAddress(); 
        return details;
    }

    public abstract string GetFullDetails();

    public abstract string GetShortDescription();

    
}