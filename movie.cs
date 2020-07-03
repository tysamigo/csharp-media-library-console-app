namespace project_csharp_media_library_console_app
{
    class Movie
    {
        public readonly string Title;
        public readonly string Director;
        public readonly string YearReleased;

        public Movie(string title, string director, string yearReleased)
        {
            Title = title;
            Director = director;
            YearReleased = yearReleased;
        }
    }
}