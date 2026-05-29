class Product
{
    private string _name;
    private string _productId;
    private float _price;
    private int _quantity;

    public Product(string name, string productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public float GetCost()
    {
        return _price * _quantity;
    }

    public string GetDisplayText()
    {
        return $"{_quantity}x {_name} ({_productId})";
    }
}