using System;

class Program
{
static void Main(string[] args)
{   
    Console.WriteLine("*****************************************************");
    Address address1 = new Address ("Dinteles 41", "Xoxhimilco", "Mexico City", "Mexico");
    Customer customer1 = new Customer("Beatriz Mass", address1);

    double order1ShippingCost = customer1.GetShippingCost();

    Product order1Product1 = new Product("Peach", "4131", 1.25, 2);
    Product order1Product2 = new Product("Kiwi", "4225", 3.50, 4);

    Order order1 = new Order(customer1);
    order1.AddProduct(order1Product1);
    order1.AddProduct(order1Product2);
    double order1Subtotal = order1.CalculateSubtotal();
    double order1Total = order1.CalculateTotal();

    order1.DisplayShippingLabel(); 
    Console.WriteLine();
    order1.DisplayPackingLabel();
    Console.WriteLine();
    order1.DisplayCosts(order1Subtotal ,order1ShippingCost, order1Total);


    Console.WriteLine("*****************************************************");


    Address address2 = new Address ("Moctezuma 45", "Coyoacan", "Mexico City", "Mexico");
    Customer customer2 = new Customer("Samantha Barajas", address2);

    double order2ShippingCost = customer2.GetShippingCost();

    Product order2Product1 = new Product("Mandarina", "4360", 4.00, 5);
    Product order2Product2 = new Product("Cherry", "4978", 2.00, 4);
    Product order2Product3 = new Product("Banana", "4129", 2.00, 2);

    Order order2 = new Order(customer2);
    order2.AddProduct(order2Product1);
    order2.AddProduct(order2Product2);
    order2.AddProduct(order2Product3);
    double order2Subtotal = order2.CalculateSubtotal();
    double order2Total = order2.CalculateTotal();


    order2.DisplayShippingLabel(); 
    Console.WriteLine();
    order2.DisplayPackingLabel();
    Console.WriteLine();
    order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
    Console.WriteLine("*****************************************************");

    }  
}
