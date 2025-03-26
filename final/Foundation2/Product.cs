public class Product
{
    private string _name;
    private string _productId;
    private float _price;
    private float _quantity;

    public Product(string name, string productId, float price, float quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }
    public float GetPrice()
    {
        return _price;
    }

    public float GetQuantity()
    {
        return _quantity;
    }

}