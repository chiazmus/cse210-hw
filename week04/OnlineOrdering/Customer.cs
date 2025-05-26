class Customer
{
    // _name : Str, _address : Address
    // LivesInUSA() : Bool, GetDisplayString() : Str

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

    public string GetDisplayString()
    {
        return $"Name: {_name},\nAddress: {_address.GetDisplayString()}";
    }


}