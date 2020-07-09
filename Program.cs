using System;

namespace project_csharp_media_library_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                
                var mediaLibrary = new MediaLibrary(new MediaType[]
                {
                    new Album("A Place To Be Real", "Day.Din", "2009"),
                    new Album("Bad", "Michael Jackson", "1987"),
                    new Book("The God Delusion", "Richard Dawkins", "2006"),
                    new Movie("Star Wars", "George Lucas", "1977"),
                    new Movie("Battlestar Galactica", "Ronald D. Moore", "1978"),
                    new VideoGame("Halo", "Xbox", "2001", "Bungie"),   
                    new VideoGame("Call of Duty", "Xbox", "2003", "Activision")
                });                         
                
                Console.WriteLine("There are " + mediaLibrary.NumberOfItems + " items currently in the Media Library");
                
                mediaLibrary.DisplayItems();

                // DetectMediaType(mediaLibrary.GetItemAt(0));
                // DetectMediaType(mediaLibrary.GetItemAt(1));
                // DetectMediaType(mediaLibrary.GetItemAt(2));
                // DetectMediaType(mediaLibrary.GetItemAt(3));
                // DetectMediaType(mediaLibrary.GetItemAt(4));
                // DetectMediaType(mediaLibrary.GetItemAt(5));
                // DetectMediaType(mediaLibrary.GetItemAt(6));
                // Console.WriteLine(" ");                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }           
        }        

        static void DetectMediaType(MediaType item)
        {
            if (item == null)
            {
                return;
            }
            
            if (item is Album)
            {
                Console.WriteLine(item.Title + " is an Album");
            }
            else if (item is Book)
            {
                Console.WriteLine(item.Title + " is a Book");
            }
            else if (item is Movie)
            {
                Console.WriteLine(item.Title + " is a Movie");
            }
            else if (item is VideoGame)
            {
                Console.WriteLine(item.Title + " is a Video Game");
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered");
            }
        }
    }
}
