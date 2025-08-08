using System;
using System.Collections.Generic;

namespace BC_Eats
{
    public enum MenuOption
    {
        Register = 1,
        ViewRegisteredMembers,
        PlaceOrder,
        ViewPlacedOrders,
        Exit
    }

    class Program
    {
        static List<Member> members = new List<Member>();
        static List<Order> orders = new List<Order>();

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                DisplayMenu();
                MenuOption choice = GetUserChoice();
                switch (choice)
                {
                    case MenuOption.Register:
                        RegisterMember();
                        break;
                    case MenuOption.ViewRegisteredMembers:
                        ViewRegisteredMembers();
                        break;
                    case MenuOption.PlaceOrder:
                        PlaceOrder();
                        break;
                    case MenuOption.ViewPlacedOrders:
                        ViewPlacedOrders();
                        break;
                    case MenuOption.Exit:
                        running = false;
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine(@"1. Register Member
2. View Registered Members
3. Place Order
4. View Placed Orders
5. Exit");
Console.Write("Select an option: ");
    
        }

        static MenuOption GetUserChoice()
        {
            int selection = Convert.ToInt32(Console.ReadLine());
            return (MenuOption)selection;
        }

        static void RegisterMember()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter ID: ");
            string id = Console.ReadLine();
            Console.Write("Is this a Student or Lecturer (s/l): ");

            char type = Console.ReadLine().ToLower()[0];

            if (type == 's')
            {
                members.Add(new Student(name, id));
            }
            else if (type == 'l')
            {
                members.Add(new Lecturer(name, id));
            }
            Console.WriteLine("Member registered successfully.");
        }

        static void ViewRegisteredMembers()
        {
            Console.WriteLine("\nRegistered Members:");
            foreach (Member member in members)
            {
                Console.WriteLine($"{member.GetType().Name} - Name: {member.Name}, ID: {member.ID}");
            }
        }

        static void PlaceOrder()
        {
            Console.Write("Enter Member ID for the order: ");
            string id = Console.ReadLine();

            Member member = members.Find(m => m.ID == id);

            if (member != null)
            {
                orders.Add(new Order(member));
                Console.WriteLine("Order placed successfully.");
            }
            else
            {
                Console.WriteLine("Member not found.");
            }
        }

        static void ViewPlacedOrders()
        {
            Console.WriteLine("\nPlaced Orders:");
            foreach (Order order in orders)
            {
                Console.WriteLine($"Order for {order.OrderedBy.Name} placed at {order.OrderTime}.");
            }
        }
    }
}

