using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        List <Order> orders = new List <Order>();

        List <Product> products1 = new List <Product>();
        products1.Add(new Product("Banana","Produce01",0.50,4));
        products1.Add(new Product("Apple","Produce02",2,3));

        Address address1 = new Address("46 Spring Street","Provo","Utah","USA");
        Customer customer1 = new Customer("Person Lastname",address1);
        Order order1 = new Order(customer1,products1);
        orders.Add(order1);


        List <Product> products2 = new List <Product>();
        products2.Add(new Product("iPhone14","Tech01",800,1));
        products2.Add(new Product("iPad Mini","Tech02",600,1));

        Address address2 = new Address("89 Fall Drive","Berlin","Berlin","Germany");
        Customer customer2 = new Customer("Man Lastname",address2);
        Order order2 = new Order(customer2,products2);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine("-Packing Label-");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine("-Shipping Label-");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"The total cost of the order is: ${Math.Ceiling((order.GetCost()) * 100) / 100:F2}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}