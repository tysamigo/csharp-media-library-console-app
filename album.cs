namespace project_csharp_media_library_console_app
{
    class Album : MediaType
    {
        public string Artist { get; private set; }

        public string DisplayText
        {
            get
            {
                return "Album: " + '"' + Title + '"' + " by " + Artist + " released in " + YearReleased + OnLoanDisplayText;

            }
        }

        public Album(string title, string artist, string yearReleased)
        : base(title, yearReleased)
        {
            Artist = artist;
        }
    }
}