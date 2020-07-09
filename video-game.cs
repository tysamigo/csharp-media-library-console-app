namespace project_csharp_media_library_console_app
{
    class VideoGame : MediaType
    {
        public string Platform { get; private set; }
        public string Developers { get; private set; }

        public VideoGame(string title, string platform, string yearReleased, string developers)
        : base(title, yearReleased)
        {
            Platform = platform;
            Developers = developers;
        }

        public string DisplayText
        {
            get
            {
                return "Album: " + '"' + Title + '"' + " by " + Developers + " released in " + YearReleased + OnLoanDisplayText;

            }
        }
    }
}