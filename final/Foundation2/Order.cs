using System.Reflection;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public void GetCost()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            double cost = product.GetPrice() * product.GetQuantity();
            totalCost += cost;
        }

        if (_customer.LivesInUsa())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        
        Console.WriteLine($"The total cost of the order is: ${Math.Ceiling(totalCost * 100) / 100:F2}");
    }

    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetName()} - {product.GetProductId()}");
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine($"{_customer.GetName()}\n{_customer.GetAddress()}");
    }
}