using System;
using System.Collections.Generic;

namespace VideoMenu
{
    class Program
    {
        static int id = 1;
        static List<Video> videos = new List<Video>();

        static void Main(string[] args)
        {
            var cust1 = new Video
            {
                Id= id++,
                VideoName = "Bob",
                VideoType = "Dilan",
                VideoLocation = "BongoStreet 232"
            };
            videos.Add(cust1);

            videos.Add(new Video()
            {
                Id=id++,
                VideoName = "Edison",
                VideoType = "Lamar",
                VideoLocation = "Sp Kirkevej 129"
            });

            //Show the first video saved internally
            //Console.WriteLine($"Name:{cust1.VideoName} {cust1.VideoType}");
            string[] menuItems =
            {           
                "List All Videos",
                "Add Video",
                "Delete Video",
                "Edit Video",
                "Exit"
            };

            //Show Menu
            //Wait for Selection
            // - Show selection or
            // - Warning and go back to menu

            var selection=ShowMenu(menuItems);
            
            while (selection!=5)
            {
                switch (selection)
                {
                    case 1:
                        ListVideos();                        
                        break;
                    case 2:
                        AddVideo();
                        break;
                    case 3:
                        DeleteVideo();
                        break;
                    case 4:
                        EditVideo();
                        break;

                    default:

                        break;
                }

                selection = ShowMenu(menuItems);

            }

            Console.WriteLine("Bye Bye!");
            Console.ReadLine();

        }

        private static void EditVideo()
        {
            var customer = FindVideoById();
            Console.WriteLine("First Name: ");
            customer.VideoName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            customer.VideoType = Console.ReadLine();
            Console.WriteLine("VideoLocation: ");
            customer.VideoLocation = Console.ReadLine();
        }

        private static Video FindVideoById()
        {
            Console.WriteLine("Insert Video Id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please insert a number");

            }
            foreach (var video in videos)
            {
                if (video.Id == id)
                {
                    return video;
                }
            }
            return null;
        }

        private static void DeleteVideo()
        {

            var videoFound = FindVideoById();
                        
            if (videoFound != null)
            {
                videos.Remove(videoFound);
            }
        }

        private static void AddVideo()
        {
            Console.WriteLine("Video Name: ");
            var videoName = Console.ReadLine();
            Console.WriteLine("Video Type: ");
            var videoType = Console.ReadLine();
            Console.WriteLine("VideoLocation: ");
            var location = Console.ReadLine();

            videos.Add(new Video()
            {
                Id = id++,
                VideoName = videoName,
                VideoType = videoType,
                VideoLocation = location,
            });

        }

        private static void ListVideos()
        {
            Console.WriteLine("\nList of Videos");
          
            foreach (var video in videos)
            {
                Console.WriteLine($"Id: {video.Id} Name: {video.VideoName} {video.VideoType} VideoLocation: {video.VideoLocation}");
            }
            Console.WriteLine("\n");
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
