public class Product
{
    // Variables
    private string _productName;
    private int _productID;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, int number, double price, int qty)
    {
        _productName = name;
        _productID = number;
        _price = price;
        _quantity = qty;
    }

    // Method for calculating product price
    public double CalculateProductPrice()
    {
        double cost = _price * _quantity;
        return cost;
    }

   //Method to return product Name
    public string GetProdName()
    {
        return _productName;
    }


    //Method to return product ID
    public int GetProdId()
    {
        return _productID;
    }


    //Method to return product Qty
    public int GetProdQty()
    {
        return _quantity;
    }
}