using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Product product;
        List<Order> orders = new List<Order> ();


        /* 1st Order */
        Order order1 = new Order("Emilio Sosa", "La Estancia", "Caracas", "Miranda", "Venezuela");
        product = new Product("Oreo", 1, 10.21, 20);
        order1.AddProduct(product);

        product = new Product("Apple Pie", 2, 30, 1);
        order1.AddProduct(product);

        product = new Product("Bread", 3, 3.50, 12);
        order1.AddProduct(product);

        orders.Add(order1);
        
        /* 2nd Order */
        Order order2 = new Order("NexusBox", "9 N Loudoun Dr", "Winchester", "Virginia", "United States");
        product = new Product("Orange", 1, 5.95, 32);
        order2.AddProduct(product);

        product = new Product("Pear", 2, 3.32, 23);
        order2.AddProduct(product);

        product = new Product("Juice", 3, 5.93, 5);
        order2.AddProduct(product);

        product = new Product("Lemon", 4, 2.43, 8);
        order2.AddProduct(product);

        product = new Product("Sugar", 3, 4.33, 2);
        order2.AddProduct(product);

        orders.Add(order2);

        foreach(Order order in orders)
        {
            Console.WriteLine("/**** ORDER ****/");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine($"\nShipping Price: ${order.ShippingCost()}");
            Console.WriteLine($"Total Price: ${order.TotalPrice()}\n");
        }


    }
}