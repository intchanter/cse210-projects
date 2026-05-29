class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddressText()
    {
        return _address.GetDisplayText();
    }

    public bool IsInUnitedStates()
    {
        return _address.GetCountry().ToUpper() == "US";
    }
}