public class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string name, int productID, double price, int quantity)
    {
        this._name = name;
        this._productID = productID;
        this._price = price;
        this._quantity = quantity;
    }

    public double GetPrice()
    {
        double price = _price * _quantity;
        return price;
    }

    // Properties
    public string Name
    {
        get
        {
            return _name;
        }
        
    }
    public int ID
    {
        get
        {
            return _productID;
        }

    }
}