using System;

namespace VideoMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] menuItems =
            {
                "Search Video",
                "Add Video",
                "Delete Video",
                "Update Videos",
                "Exit"
            };



            var selection = ShowMenu(menuItems);

            while (selection != 5)
            {
                
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Search Video");
                        break;
                    case 2:
                        Console.WriteLine("Add Video");
                        break;
                    case 3:
                        Console.WriteLine("Delete Video");
                        break;
                    case 4:
                        Console.WriteLine("Edit Video");
                        break;

                    default:

                        break;
                }
                
                selection = ShowMenu(menuItems);
                
            }
            
            Console.WriteLine("Back soon");
            Console.ReadLine();


        }

        private static int ShowMenu(string[] menuItems)
        {
            
            Console.WriteLine("Welcome Club Edi:\n ");

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine((i + 1) + ":" + menuItems[i]);

            }

            int selection;
            
            while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > 5)
            {
                Console.WriteLine("Please enter a valid option");
            }
            Console.WriteLine("Selection: " + selection+ "\n");
            return selection;
            
        }

    }
}
