using System;

namespace Foundation2
{
public class Program
{
    static void Main(string[] args)
    {
       //Welcome message
        Console.WriteLine("\nOnline Ordering Program!\n");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();      


        //Add first customer order
        Address address1 = new Address("1234 Question St.", "High Springs", "FL", "84201", "USA");
        Customer customer1 = new Customer("Bob Ross", address1);
        Order order1 = new Order(customer1);
        order1.AddProducts("Soda", 2319, 2.50, 6);
        order1.AddProducts ("Candybar", 2589, 1.75, 3);
        order1.AddProducts("Milk", 4712, 3.75, 2);
        order1.AddProducts("Bread", 3597, 2.98, 3);


        //Add second customer order
        Address address2 = new Address("720 E Railway St.", "Raymond", "AB", "T0K 2S0", "CANADA");
        Customer customer2 = new Customer("Natalie Portman", address2);
        Order order2 = new Order(customer2);
        order2.AddProducts("Pancake Mix", 1489, 3.99, 4);
        order2.AddProducts("Oil", 1264, 2.80, 2);
        order2.AddProducts("Milk", 4712, 3.75, 3);
        order2.AddProducts("Dzn Eggs", 3190, 3.25, 2);

        //Add third customer order
        Address address3 = new Address("143 Popular St.", "Palm Springs", "CA", "92262", "USA");
        Customer customer3 = new Customer("Tom Cruise", address3);
        Order order3 = new Order(customer3);
        order3.AddProducts("Soda", 2319, 2.50, 6);
        order3.AddProducts ("Candybar", 2589, 1.75, 3);
        order3.AddProducts("Milk", 4712, 3.75, 2);
        order3.AddProducts("Bread", 3597, 2.98, 3);


        //Add second customer order
        Address address4 = new Address("6650 Niagara Parkway.", "Niagara Falls", "ON", "L2H 6T3 ", "CANADA");
        Customer customer4 = new Customer("Celine Dion", address4);
        Order order4 = new Order(customer4);
        order4.AddProducts("Pancake Mix", 1489, 3.99, 4);
        order4.AddProducts("Oil", 1264, 2.80, 2);
        order4.AddProducts("Milk", 4712, 3.75, 3);
        order4.AddProducts("Dzn Eggs", 3190, 3.25, 2);


        //Create a list to hold orders
        List<Order> _orders = new List<Order>{order1, order2};

        //Iterate through the list of orders to display shipping and product labels with a total cost
        int i = 1;
        foreach (Order o in _orders)
        {
            Console.Clear();
            Console.WriteLine($"Order #{i}\n");
            i += 1;
            Console.WriteLine($"Shipping Label:\n\n{o.MakeShippingLabel()}\n");
            Console.WriteLine($"Packaging Label:\n\n{o.MakePackingLabel()}");
            Console.WriteLine($"Order Total: ${o.TotalPurchasePrice()}");
            Console.WriteLine("\nPress any key for next order...");   
            Console.ReadKey();            
            }


            //Closing message
            Console.WriteLine("\nThanks for using the Online Ordering System!!\n");

        }
    }
}
    
