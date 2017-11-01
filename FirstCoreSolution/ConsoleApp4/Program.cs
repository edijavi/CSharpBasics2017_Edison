using System;
using System.Collections.Generic;


namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>
            {
                "Scissors",
                "paper",
                "rock"
            };
                           
            var i = 0;
            while(i<words.Count)
            {
                Console.WriteLine(words[i]);
                i++;
                                
            }

            Console.WriteLine("--------------");
            for (var j = 0; j<words.Count; j++)
            {
                Console.WriteLine(words[j]);
            }

            Console.WriteLine("--------------");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
            //["paper","Scissors", "rock"]
        }
    }
}
