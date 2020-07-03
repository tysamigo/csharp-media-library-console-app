namespace project_csharp_media_library_console_app
{
    class Album
    {
        public readonly string Title;
        public readonly string Artist;
        public readonly string YearReleased;

        public Album(string title, string artist, string yearReleased)
        {
            Title = title;
            Artist = artist;
            YearReleased = yearReleased;
        }
    }
}