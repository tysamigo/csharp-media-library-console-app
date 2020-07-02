using System;

namespace project_csharp_media_library_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var album = new Album();
            album.Title = "A Place To Be Real";
            album.Artist = "Day.Din";
            album.YearReleased = "2009";

            var book = new Book();
            book.Title = "The God Delusion";
            book.Author = "Richard Dawkins";
            book.YearReleased = "2006";

            var movie = new Movie();
            movie.Title = "Star Wars";
            movie.Director = "George Lucas";
            movie.YearReleased = "1977";

            var videoGame = new VideoGame();
            videoGame.Title = "Halo";
            videoGame.Developers = "Bungie";
            videoGame.YearReleased = "2001";

            Console.WriteLine("Album: " + '"' + album.Title + '"' + " by " + album.Artist + " released in " + album.YearReleased);
            Console.WriteLine("Book: " + '"' + book.Title + '"' + " by " + book.Author + " released in " + book.YearReleased);
            Console.WriteLine("Movie: " + '"' + movie.Title + '"' + " by " + movie.Director + " released in " + movie.YearReleased);
            Console.WriteLine("Video Game: " + '"' + videoGame.Title + '"' + " by " + videoGame.Developers + " released in " + videoGame.YearReleased);
        }
    }
}
