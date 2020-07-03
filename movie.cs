namespace project_csharp_media_library_console_app
{
    class Movie
    {
        public string Title;
        public string Director;
        public string YearReleased;

        public Movie(string title, string director, string yearReleased)
        {
            Title = title;
            Director = director;
            YearReleased = yearReleased;
        }
    }
}