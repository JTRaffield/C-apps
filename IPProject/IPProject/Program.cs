using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPProject
{
    class Program
    {        

        public static List<Address> IPList = new List<Address>();
        public static int option = 0;
        public static bool IsIPAddress;

        static void Main()
        {
            CreateList();
            MainMenu();
            do
            {
                switch (option)
                {
                    case 1:
                        AddIP(IPList);
                        break;
                    case 2:
                        DeleteIP(IPList);
                        break;
                    case 3:
                        Search(IPList);
                        break;
                    case 4:
                        ViewList(IPList);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    case 6:
                        AddDescription(IPList);
                        break;
                    default:
                        break;
                }
            } while (option != 5);
        }
        
        //First thing done by the user, it takes the inputs, tests for valid format and then adds to list if they are formatted correctly
        public static List<Address> CreateList()
        {
            Console.WriteLine("Enter each IP followed by pressing the enter key.");
            Console.WriteLine("When finished type 'end' to go to the menu.\n\n");
            bool again = true;
            do
            {
                Address ip = new Address();
                Console.WriteLine("Enter IP address or 'end' to go to the menu.");
                string input = Console.ReadLine();
                IsIPAddress = TestInput(input);
                if (IsIPAddress)
                {
                    ip.number = input;
                    IPList.Add(ip);
                }
                else if (input.ToLower() == "end")
                {
                    again = false;
                }
                else
                {
                    Console.WriteLine("Please enter a correct IP address.");
                }
            } while (again);
            return IPList;
         }

        //presents the user with the choices available and passes the input to Main()
        public static int MainMenu()
        {
            Console.WriteLine("\n***********************");
            Console.WriteLine("Choose what you want to do. 1, 2, 3, 4, 5 or 6");
            Console.WriteLine("1. Add an IP address \n2. Delete an IP address \n3. Search for an IP address \n4. View List \n5. Exit \n6. Add a Description");
            option = Convert.ToInt32(Console.ReadLine());
            if (option == 5)
            {
                Environment.Exit(0);
            }          
            return option;
        }

        //Adds an entered ip address into the list
        public static List<Address> AddIP(List<Address> IPList)
        {
            Console.WriteLine("\n\n***********************");
            Console.WriteLine("Enter the IP address you want to add to the list, or type 'end' to return to the main menu.");
            Address ip = new Address();
            string input = Console.ReadLine();
            IsIPAddress = TestInput(input);
            if (IsIPAddress)
            {
                 ip.number = input;
                 IPList.Add(ip);
            }
            else if (input.ToLower() == "end")
            {
                MainMenu();
            }
            else if (!IsIPAddress)
            {
                Console.WriteLine("Please enter a valid IP address or type 'end' to return to the menu.");
            }
            return IPList;
        }

        //removes an IP address from the list, if it is present
        public static List<Address> DeleteIP(List<Address> IPList)
        {
            Console.WriteLine("\n\n***********************");
            Console.WriteLine("Enter the IP that you wish to remove from the list, or type 'end' to return to the menu.");
            string input = Console.ReadLine();
            IsIPAddress = TestInput(input);
            if (IsIPAddress)
            {
                var itemToRemove = IPList.Find(Address => Address.number.Contains(input));
                IPList.Remove(itemToRemove);
            }
            else if (input.ToLower() == "end")
            {
                MainMenu();
            }
            else
            {
                Console.WriteLine("Please enter a valid IP address or type 'end' to return to the menu.");
            }
            return IPList;
        }

        //Searches the list for an exact ip matching what the user inputs
        public static void Search(List<Address> IPList)
        {
            bool again = true;
            do 
            {
                Console.WriteLine("\n\n***********************");
                Console.WriteLine("What IP address are you looking for?");
                string search = Console.ReadLine();
                IsIPAddress = TestInput(search);
            
                if (IsIPAddress)
                {
                    Address result = IPList.Find(address => address.number == search);
                    if (result != null)
                    {
                        Console.WriteLine("That address is currently in the list.");
                        Console.WriteLine("***********************\n");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that address is not in the list.");
                        Console.WriteLine("***********************\n");
                        Console.ReadKey();

                    }
                    Console.WriteLine("Do you want to look for another IP address? \n Yes or No");
                    string searchAgain = Console.ReadLine();
                    if (searchAgain.ToLower() == "no")
                    {
                        again = false;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid IP address or type 'end' to return to the menu");
                }
            } while (again == true);
            MainMenu();
        }

        //views the IP addresses that are currently in the list created by the user
        public static void ViewList(List<Address> IPList)
        {
            Console.WriteLine("\n\n***********************");
            Console.WriteLine("The current list of IP addresses is: ");
            foreach(var i in IPList)
            {
                Console.WriteLine("************************");
                Console.WriteLine(i.number);
                Console.WriteLine(i.description);
            }
            Console.ReadLine();
            MainMenu();
        }

        public static bool TestInput(string input)
        {
            char FullStop = '.';
            string[] arrOctets = input.Split(FullStop);
            if (arrOctets.Length != 4)
            {
                return false;
            }
            short MaxVal = 255;
            int temp;
            foreach (string octet in arrOctets)
            {
                if (octet.Length > 3)
                {
                    return false;
                }

                temp = int.Parse(octet);
                if(temp > MaxVal)
                {
                    return false;
                }
            }
            return true;
        }

        //Add a description to an IP address in the list so that the user can track their network better
        public static List<Address> AddDescription(List<Address> IPList)
        {
            Console.WriteLine("\n\n***********************");
            Console.WriteLine("Enter the IP that you wish to add a description to, or type 'end' to return to the menu.");
            string input = Console.ReadLine();
            IsIPAddress = TestInput(input);
            if (IsIPAddress)
            {
                Console.WriteLine("Write the description followed by the enter key.");
                string desc = Console.ReadLine();
                var obj = IPList.FirstOrDefault(x => x.number == input);
                if (obj != null) obj.description = desc;
            }
            else if (input.ToLower() == "end")
            {
                MainMenu();
            }
            else
            {
                Console.WriteLine("Please enter a valid IP address or type 'end' to return to the menu.");
            }
            return IPList;
        }
    }
}
