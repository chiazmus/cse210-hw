class Product
{
    // _name : Str, _id : Int, _price : Double, _quantity : Int
    // GetPrice() : Double, GetDisplayString() : Str

    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetPrice()
    {
        return _price * _quantity;
    }

    public string GetDisplayString()
    {
        return $"Name: {_name}, ID: {_id}";
    }


}