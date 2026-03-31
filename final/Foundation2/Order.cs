
public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public int GetShippingCost()
    {
        if (_customer.IsLivingInUsa())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public double OrderTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.Total();
        }
        return total + GetShippingCost();
    }
    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetId()})\n";
        }
        return label;
    }
    public string GetShippingLabel()
    { 
        return $"Shipping Label:\n{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}";
    }
}