using System;

namespace project_csharp_media_library_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var album = new Album("A Place To Be Real", "Day.Din", "2009");
            var album1 = new Album("Bad", "Michael Jackson", "1987");
            var book = new Book("The God Delusion", "Richard Dawkins", "2006");
            var movie = new Movie("Star Wars", "George Lucas", "1977");
            var movie1 = new Movie("Battlestar Galactica", "Ronald D. Moore", "1978");
            var videoGame = new VideoGame("Halo", "Xbox", "2001", "Bungie");            
            var videoGame1 = new VideoGame("Call of Duty", "Xbox", "2003", "Activision");

            Console.WriteLine(album.GetDisplayText());
            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(book.GetDisplayText());
            Console.WriteLine(movie.GetDisplayText());
            Console.WriteLine(movie1.GetDisplayText());
            Console.WriteLine(videoGame.GetDisplayText());
            Console.WriteLine(videoGame1.GetDisplayText());
            Console.WriteLine(" ");

            album.LoanMedia("Tyler Ramage");
            album1.LoanMedia();
            movie1.LoanMedia("Lacey Ramage");
            videoGame1.LoanMedia("Tyler Ramage");


            Console.WriteLine(album.GetDisplayText());
            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(movie1.GetDisplayText());
            Console.WriteLine(videoGame1.GetDisplayText());

            album.ReturnMedia();
            album1.ReturnMedia();
            movie1.ReturnMedia();
            videoGame1.ReturnMedia();

            Console.WriteLine(album.GetDisplayText());
            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(movie1.GetDisplayText());
            Console.WriteLine(videoGame1.GetDisplayText());
        }
    }
}
