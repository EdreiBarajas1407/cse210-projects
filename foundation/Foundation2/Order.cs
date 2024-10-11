public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer {get; set;}

    public  Order(Customer customer)
    {

    }

    public void AddProduct(Product product)
    {

    }

    public double CalculateSubtotal() 
    {
        return 0;
    }

    public double CalculateTotal()
    {
        return 0;
    }

    public void DisplayCosts(double subtotal, double shippingCost, double totalCost)
    {   

    }

    public void DisplayPackingLabel()
    {   
        
    }
    public void DisplayShippingLabel()
    {   

    }

    
}