namespace project_csharp_media_library_console_app
{
    class Album : MediaType
    {
        public string Artist { get; private set; }

        public string DisplayText
        {
            get
            {
                string text = "Album: " + '"' + Title + '"' + " by " + Artist + " released in " + YearReleased;

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

        public Album(string title, string artist, string yearReleased)
        : base(title, yearReleased)
        {
            Artist = artist;
        }
    }
}