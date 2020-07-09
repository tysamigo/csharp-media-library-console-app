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
                string text = "Movie: " + '"' + Title + '"' + " by " + Director + " released in " + YearReleased;

                if (OnLoan)
                {
                    if (!string.IsNullOrEmpty(Loanee))
                    {
                        text += " - (Currently on loan to " + Loanee + ")";
                    }
                    else
                    {
                        text += " - (Currently on loan)";
                    }
                }

                return text;
            }
        }
    }
}