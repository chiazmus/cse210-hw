class Order
{
    // _products : List<Product>, _customer : Customer
    // AddProduct() : Void, GetPrice() : Double, GetPackingLabel() : Str, GetShippingLabel() : Str

    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetPrice()
    {
        int shippingCost = _customer.LivesInUSA() ? 5 : 35; // $5 for USA, $35 for outside the USA shipping
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetPrice();
        }

        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += product.GetDisplayString() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetDisplayString();
    }
}