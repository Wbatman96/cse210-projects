public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public float TotalCost()
    {
        return 0;
    }

    public string PackingLabel()
    {
        string packing = "";
        foreach(Product product in _products)
        {
            packing += product.DisplayProduct()+"\n";
        }
        return packing;
    }

    public string ShippingLabel()
    {
        return "";
    }
}