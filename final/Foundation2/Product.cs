public class Product
{
    private string _productName = "";
    private int _productId = 0;
    private float _price = 0;
    private int _quantity = 0;

    public Product(string productName, int productId, float price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public float ProductTotal()
    {
        float pTotal = _price * _quantity;
        return pTotal;
    }
}