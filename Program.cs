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
            var videoGame = new VideoGame("Halo", "Xbox", "2001", "Bungie");

            Console.WriteLine(album.GetDisplayText());
            Console.WriteLine(book.GetDisplayText());
            Console.WriteLine(movie.GetDisplayText());
            Console.WriteLine(videoGame.GetDisplayText());

            album.LoanMedia("Tyler Ramage");
            album1.LoanMedia();

            Console.WriteLine(album.GetDisplayText());
            Console.WriteLine(album1.GetDisplayText());

            album.ReturnMedia();
            album1.ReturnMedia();

            Console.WriteLine(album.GetDisplayText());
            Console.WriteLine(album1.GetDisplayText());
        }
    }
}
