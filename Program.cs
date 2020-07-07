using System;

namespace project_csharp_media_library_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                
                // var items = new MediaType[]
                MediaType[] items = 
                {
                    new Album("A Place To Be Real", "Day.Din", "2009"),
                    new Album("Bad", "Michael Jackson", "1987"),
                    new Book("The God Delusion", "Richard Dawkins", "2006"),
                    new Movie("Star Wars", "George Lucas", "1977"),
                    new Movie("Battlestar Galactica", "Ronald D. Moore", "1978"),
                    new VideoGame("Halo", "Xbox", "2001", "Bungie"),   
                    new VideoGame("Call of Duty", "Xbox", "2003", "Activision")
                };               
                
                DetectMediaType(items[0]);
                DetectMediaType(items[1]);
                DetectMediaType(items[2]);
                DetectMediaType(items[3]);
                DetectMediaType(items[4]);
                DetectMediaType(items[5]);
                DetectMediaType(items[6]);
                Console.WriteLine(" ");
               
                // Console.WriteLine(album.GetDisplayText());
                // Console.WriteLine(album1.GetDisplayText());
                // Console.WriteLine(book.GetDisplayText());
                // Console.WriteLine(movie.GetDisplayText());
                // Console.WriteLine(movie1.GetDisplayText());
                // Console.WriteLine(videoGame.GetDisplayText());
                // Console.WriteLine(videoGame1.GetDisplayText());
                // Console.WriteLine(" ");

                // album.LoanMedia("Tyler Ramage");
                // album1.LoanMedia();
                // movie1.LoanMedia("Lacey Ramage");
                // videoGame1.LoanMedia("Tyler Ramage");


                // Console.WriteLine(album.GetDisplayText());
                // Console.WriteLine(album1.GetDisplayText());
                // Console.WriteLine(movie1.GetDisplayText());
                // Console.WriteLine(videoGame1.GetDisplayText());
                // Console.WriteLine(" ");

                // album.ReturnMedia();
                // album1.ReturnMedia();
                // movie1.ReturnMedia();
                // videoGame1.ReturnMedia();

                // Console.WriteLine(album.GetDisplayText());
                // Console.WriteLine(album1.GetDisplayText());
                // Console.WriteLine(movie1.GetDisplayText());
                // Console.WriteLine(videoGame1.GetDisplayText());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }           
        }

        static void DetectMediaType(MediaType item)
        {
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
