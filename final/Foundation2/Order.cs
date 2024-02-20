public class Order
{
    // Variables
    List<Product> _products = new List<Product>();
    private Customer _customer;


    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Method for adding product list
    public void AddProducts(string name, int id, double price, int qty)
    {
        Product product = new Product(name, id, price, qty);
        _products.Add(product);
    }

    // Method to display the shipping label info
    public string MakeShippingLabel()
    {
        string shippingLabel = ($" {_customer.GetName()}\n{_customer.GetCustomerAddress()}\n");
        return shippingLabel;
    }

    // Method for displaying packing lable info
    public string MakePackingLabel()
    {
        string productLabel = "";
        foreach (Product p in _products)
        {
            productLabel += ($" Product ID: {p.GetProdId()} -- {p.GetProdName()} -- {p.GetProdQty()}\n");
        }
        return productLabel;
    }

    // Method for setting shipping cost based on country 
    public int GetShippingCost()
    {
        if (_customer.CheckCountry())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    // Method for calculating order total
    public double TotalPurchasePrice()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.CalculateProductPrice();
        }
        total += GetShippingCost();
        return total;
    }
}