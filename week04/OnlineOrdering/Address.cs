class Address
{
    // _street : Str, _city : Str, _state : Str, _country : Str
    // IsInUSA() : Bool, GetDisplayString() : Str
    
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public string GetDisplayString()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }

}