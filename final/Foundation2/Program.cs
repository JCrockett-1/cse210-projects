using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products1 = new List<Product>();
        products1.Add(new Product("Banana", "Produce06", 0.79, 3.5));
        products1.Add(new Product("Apple", "Produce07", 1.29, 5.0));
        products1.Add(new Product("Orange", "Produce08", 0.99, 4.0));

        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("Jerry Andrews", address1);

        Order order1 = new Order(customer1, products1);
        order1.GetCost();
        Console.WriteLine();
        order1.GetPackingLabel();
        Console.WriteLine();
        order1.GetShippingLabel();

        List<Product> products2 = new List<Product>();
        products2.Add(new Product("Laptop", "Electronics01", 999.99, 5.5));
        products2.Add(new Product("Mouse", "Electronics02", 49.99, 0.5));
        products2.Add(new Product("Keyboard", "Electronics03", 79.99, 2.0));

        Address address2 = new Address("456 Tech Lane", "San Francisco", "CA", "USA");
        Customer customer2 = new Customer("Sarah Johnson", address2);

        Order order2 = new Order(customer2, products2);
        Console.WriteLine();
        order2.GetCost();
        Console.WriteLine();
        order2.GetPackingLabel();
        Console.WriteLine();
        order2.GetShippingLabel();

        List<Product> products3 = new List<Product>();
        products3.Add(new Product("Bread", "Bakery01", 3.49, 1.5));
        products3.Add(new Product("Milk", "Dairy02", 2.99, 1.0));
        products3.Add(new Product("Eggs", "Dairy03", 4.29, 2.0));

        Address address3 = new Address("789 Grocery St", "Chicago", "IL", "USA");
        Customer customer3 = new Customer("Mike Roberts", address3);

        Order order3 = new Order(customer3, products3);
        Console.WriteLine();
        order3.GetCost();
        Console.WriteLine();
        order3.GetPackingLabel();
        Console.WriteLine();
        order3.GetShippingLabel();
    }
}