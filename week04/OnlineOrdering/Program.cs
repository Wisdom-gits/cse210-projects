using System;
using System.Collections.Generic;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_productId})";
    }
}

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.Trim().ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddressString()
    {
        return _address.GetFullAddress();
    }
}

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        // Add shipping
        total += _customer.LivesInUSA() ? 5 : 35;

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";
        foreach (Product p in _products)
        {
            label += " - " + p.GetPackingLabel() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\n{_customer.GetName()}\n{_customer.GetAddressString()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address addr1 = new Address("123 Apple St", "New York", "NY", "USA");
        Address addr2 = new Address("45 Maple Rd", "Toronto", "ON", "Canada");

        // Create customers
        Customer cust1 = new Customer("John Doe", addr1);
        Customer cust2 = new Customer("Mary Johnson", addr2);

        // Create orders
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Keyboard", "KBD101", 25.99, 2));
        order1.AddProduct(new Product("Mouse", "MSE404", 14.99, 1));
        order1.AddProduct(new Product("Headset", "HST909", 39.99, 1));

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Laptop", "LPT333", 799.99, 1));
        order2.AddProduct(new Product("HDMI Cable", "HDM212", 9.99, 2));

        // Display order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        // Display order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}
