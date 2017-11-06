using System;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer();
            cust1.FistName = "Bob";
            cust1.LastName = "Dilan";
            cust1.Address = "Bongo 23";

            Console.WriteLine($"Name:{cust1.FistName} {cust1.LastName}");
            string[] menuItems =
            {           
                "List All Customers",
                "Add customer",
                "Delete Customer",
                "Edit Customner",
                "Exit"
            };

            //Show Menu
            //Wait for Selection
            // - Show selection or
            // - Warning and go back to menu

            var selection=ShowMenu(menuItems);

            /*if (selection==1)
            {
                Console.WriteLine("List Customers");
            }
            else if (selection==2)
            {
                Console.WriteLine("Add Customers");
            }
            else if (selection == 3)
            {
                Console.WriteLine("Delete Customers");
            }
            else if (selection == 4)
            {
                Console.WriteLine("Edit Customers");
            }
            else
            {
                Console.WriteLine("Bye Bye!");
            }

            */
            while (selection!=5)
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("List Customers");
                        break;
                    case 2:
                        Console.WriteLine("Add Customers");
                        break;
                    case 3:
                        Console.WriteLine("Delete Customers");
                        break;
                    case 4:
                        Console.WriteLine("Edit Customers");
                        break;

                    default:

                        break;
                }

                selection = ShowMenu(menuItems);

            }

            Console.WriteLine("Bye Bye!");
            Console.ReadLine();

        }

        private static int ShowMenu(string[] menuItems)
        {
            Console.WriteLine("Select What you want to do:\n ");
            
            for (int i = 0; i < menuItems.Length; i++)
            {
                //Console.WriteLine((i + 1) + ":" + menuItems[i]);
                Console.WriteLine($"{(i + 1)}: {menuItems[i]}");
            }
            

            int selection;
            
            while (!int.TryParse(Console.ReadLine(), out selection) || selection<1 ||selection>5)
            {
                Console.WriteLine("You need to select number between 1-5");
            }

            Console.WriteLine("Selection: " + selection);
            return selection;
        }
    }
}
