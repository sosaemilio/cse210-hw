public class Customer
{
    private string _name;
    private Address _address;

    public Customer() {} // Constructor

    public string Name // Property
    {
        get
        {
            return _name;
        }
    }

    public void SetCustomer(string name, string street, string city, string state, string country)
    {
        this._name = name;
        this._address = new Address(street, city, state, country);
    }

    public bool LiveInUS()
    {
        return _address.IsUS();
    }

    public string Address
    {
        get
        {
            return _address.GetAddress();
        }
        
    }
}