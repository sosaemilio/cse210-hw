public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(string name, string street, string city, string state, string country)
    {
       _customer = new Customer();
       _customer.SetCustomer(name, street, city, state, country);
       _products = new List<Product> ();

    }
    public int ShippingCost()
    {
        int shippingCost = 0;
        if (_customer.LiveInUS() == true)
        {
            shippingCost = 15;
        }
        else 
        {
            shippingCost = 35;
        }
        return shippingCost;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalPrice()
    {
        double subTotal = 0;
        foreach (Product product in _products)
        {
            subTotal += product.GetPrice();
        }
        double total = subTotal + ShippingCost();
        return Math.Round(total, 2);
    }
    
    public string PackingLabel()
    {
        string label = "-------Packing Label-------";
        foreach(Product product in _products)
        {
            label += "\n" + product.Name + " - ID: " + product.ID;
        }
        label += "\n---------------------------";
        return label;
    }

    public string ShippingLabel()
    {
        string label = "-------Shipping Label -------\n";
        label += _customer.Name + "\n" + _customer.Address;
        label += "\n-----------------------------";
        return label;
    }
}