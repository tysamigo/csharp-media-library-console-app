namespace project_csharp_media_library_console_app
{
    class Movie : MediaType
    {
        public string Director { get; private set; }

        public Movie(string title, string director, string yearReleased)
        : base(title, yearReleased)
        {
            Director = director;
        }

        public string DisplayText
        {
            get
            {
                return "Movie: " + '"' + Title + '"' + " by " + Director + " released in " + YearReleased + OnLoanDisplayText;

            }
        }
    }
}