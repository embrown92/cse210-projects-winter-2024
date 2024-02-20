using System.Collections.Concurrent;

public class Address
{
    // Variables
    private string _street;
    private string _city;
    private string _state;
    private string _zipcode;
    private string _country;

    // Constructor
    public Address(string street, string city, string state, string zipcode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipcode = zipcode;
        _country = country;
    }

    // Method to check if address is in USA
    public bool InUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Method to return an address string
    public string GetAddress()
    {
        return ($" {_street}\n {_city} {_zipcode}\n {_country}");
    }
}