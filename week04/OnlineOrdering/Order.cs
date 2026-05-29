class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = [];
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float GetSubtotal()
    {
        float subtotal = 0.0f;
        foreach (Product product in _products)
        {
            subtotal += product.GetCost();
        }
        return subtotal;
    }

    public float GetShipping()
    {
        return (
            _customer.IsInUnitedStates()
            ? 5.00f
            : 35.00f
        );
    }

    public float GetTotal()
    {
        return GetSubtotal() + GetShipping();
    }

    public string GetShippingLabelText()
    {
        return (
            $"{_customer.GetName()}\n"
            + $"{_customer.GetAddressText()}"
        );
    }

    public string GetPackingLabelText()
    {
        List<string> lines = [];

        foreach (Product product in _products)
        {
            lines.Add(product.GetDisplayText());
        }

        return String.Join("\n", lines);
    }
}