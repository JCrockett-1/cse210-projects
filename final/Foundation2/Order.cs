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

    public double GetCost()
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
        
        return totalCost;
    }

    public string GetPackingLabel()
    {
        List <string> lines = new List<string>();

        foreach (Product product in _products)
        {
            lines.Add($"{product.GetQuantity()}x {product.GetName()} ({product.GetProductId()})");
        }

        string packingLabel = string.Join("\n",lines);
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return ($"{_customer.GetName()}\n{_customer.GetAddress()}");
    }
}