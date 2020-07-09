using System;

namespace project_csharp_media_library_console_app
{
    class MediaLibrary
    {
        private MediaType[] _items;

        //The line of code below is the short version for the code just below it
        // public int NumberOfItems => _items.Length;
        public int NumberOfItems
        {
            get
            {
                return _items.Length;
            }
        }

        public MediaLibrary(MediaType[] items)
        {
            _items = items;
        }

        public void DisplayItems()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                DisplayItem(_items[i]);
            }
        }

        public static void DisplayItem(MediaType item)
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
                Console.WriteLine(book.DisplayText);
            }
            else if (item is Movie)
            {
                var movie = (Movie)item;
                Console.WriteLine(movie.DisplayText);
            }
            else if (item is VideoGame)
            {
                var videoGame = (VideoGame)item;
                Console.WriteLine(videoGame.DisplayText);
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered");
            }
        }

        public MediaType GetItemAt(int index)
        {
            if (index < _items.Length)
            {
                return _items[index];
            }
            else
            {
                Console.WriteLine("An element at index " + index + " doesn't exist in the media library.");
                return null;
            }

            // This is the Ternary If Operator which can be used
            //the above If Statement
            // return (index < _items.Length) ? _items[index] : null;
        }
    }
}