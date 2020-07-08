namespace project_csharp_media_library_console_app
{
    class MediaLibrary
    {
        private MediaType[] _items;

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
                return null;
            }            
        }
    }
}