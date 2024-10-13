class Product
{
    private string _productName {get; set;}
    private string _productId {get; set;}
    private  double _productPrice {get; set;}
    private int _productQuantity {get; set;}

    public Product (string name, string id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _productPrice = price;
        _productQuantity = quantity;
    }

    public double CalculatePrice()
    {
        return Math.Round((_productPrice * _productQuantity),2);
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine($"{_productName} ({_productId}) => Total: ${CalculatePrice()}");
    }
}