public class Customer
{
    // Variables
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method for getting the customer's name
    public string GetName()
    {
        return _name;
    }

    // Check country method
    public bool CheckCountry()
    {
        return _address.InUSA();
    }

    // Method for returning customer's address string
    public string GetCustomerAddress()
    {
        string customerAddress = _address.GetAddress();
        return customerAddress;
    }
}