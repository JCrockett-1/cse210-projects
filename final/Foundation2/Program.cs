using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products1 = new List<Product>();
        products1.Add(new Product("Banana", "Produce06", 0.79f, 3.5f));
        products1.Add(new Product("Apple", "Produce07", 1.29f, 5.0f));
        products1.Add(new Product("Orange", "Produce08", 0.99f, 4.0f));

        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("Jerry Andrews", address1);

        Order order1 = new Order(customer1, products1);
        order1.GetCost();
        Console.WriteLine();
        order1.GetPackingLabel();
        Console.WriteLine();
        order1.GetShippingLabel();

        List<Product> products2 = new List<Product>();
        products2.Add(new Product("Laptop", "Electronics01", 999.99f, 5.5f));
        products2.Add(new Product("Mouse", "Electronics02", 49.99f, 0.5f));
        products2.Add(new Product("Keyboard", "Electronics03", 79.99f, 2.0f));

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
        products3.Add(new Product("Bread", "Bakery01", 3.49f, 1.5f));
        products3.Add(new Product("Milk", "Dairy02", 2.99f, 1.0f));
        products3.Add(new Product("Eggs", "Dairy03", 4.29f, 2.0f));

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