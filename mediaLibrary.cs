namespace project_csharp_media_library_console_app
{
    class MediaLibrary
    {
        private MediaType[] _items;

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

        public MediaType GetItemAt(int index)
        {
            if (index < _items.Length)
            {
                return _items[index];
            }
            else
            {
                System.Console.WriteLine("An element at index " + index + " doesn't exist in the media library.");
                return null;
            }            

            // This is the Ternary If Operator which can be used
            //the above If Statement
            // return (index < _items.Length) ? _items[index] : null;
        }
    }
}