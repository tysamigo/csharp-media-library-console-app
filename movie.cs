namespace project_csharp_media_library_console_app
{
    class Movie : MediaType
    {
        public readonly string Director;

        public Movie(string title, string director, string yearReleased)
        : base(title, yearReleased)
        {
            Director = director;
        }

        public string GetDisplayText()
        {
            return ("Movie: " + '"' + Title + '"' + " by " + Director + " released in " + YearReleased);
        }
    }
}