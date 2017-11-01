using System;
//w3resource.com/exercise 5
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool aNumber = false;
            var firstInputAsInt = -1;

            while(!aNumber)
            {
                Console.WriteLine("Input the First Number: ");
                var firstInputAsText = Console.ReadLine();
                try
                {
                    firstInputAsInt = int.Parse(firstInputAsText);
                    aNumber = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Thats not an int, try again");
                }
            }



            Console.WriteLine("Input the second number: ");
            var secondInputAsText = Console.ReadLine();
            int secondInputAsInt;

            while(!int.TryParse(secondInputAsText, out secondInputAsInt))
            {
                Console.WriteLine("Thats not an int, try again");
                Console.WriteLine("Input the second number: ");
                secondInputAsText = Console.ReadLine();

            }

            int temp;

            temp = firstInputAsInt;
            firstInputAsInt = secondInputAsInt;
            secondInputAsInt = temp;

            Console.WriteLine("first value: " + firstInputAsInt + " second value: " + secondInputAsInt);
    
            Console.ReadLine();

        }
    }
}
