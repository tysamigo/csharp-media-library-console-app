﻿using System;

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
                
                DetectMediaType(mediaLibrary.GetItemAt(0));
                DetectMediaType(mediaLibrary.GetItemAt(1));
                DetectMediaType(mediaLibrary.GetItemAt(2));
                DetectMediaType(mediaLibrary.GetItemAt(3));
                DetectMediaType(mediaLibrary.GetItemAt(4));
                DetectMediaType(mediaLibrary.GetItemAt(5));
                DetectMediaType(mediaLibrary.GetItemAt(6));
                Console.WriteLine(" ");

                Display(mediaLibrary.GetItemAt(0));
                Display(mediaLibrary.GetItemAt(1));
                Display(mediaLibrary.GetItemAt(2));
                Display(mediaLibrary.GetItemAt(3));
                Display(mediaLibrary.GetItemAt(4));
                Display(mediaLibrary.GetItemAt(5));
                Display(mediaLibrary.GetItemAt(6));
                Display(mediaLibrary.GetItemAt(7));
               
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

        static void Display(MediaType item)
        {
            
            if (item == null)
            {
                return;
            }
            
            if (item is Album)
            {
                // using Explicit Cast but don't understand
                var album = (Album)item;
                // Console.WriteLine(album.GetDisplayText());                
            }
            else if (item is Book)
            {
                var book = (Book)item;
                // Console.WriteLine(book.GetDisplayText());                
            }
            else if (item is Movie)
            {
                var movie = (Movie)item;
                // Console.WriteLine(movie.GetDisplayText());                
            }
            else if (item is VideoGame)
            {
                var videoGame = (VideoGame)item;
                // Console.WriteLine(videoGame.GetDisplayText());                
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered");
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
