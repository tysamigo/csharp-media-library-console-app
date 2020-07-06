namespace project_csharp_media_library_console_app
{
    class VideoGame : MediaType
    {
        public readonly string Platform;
        public readonly string Developers;

        public VideoGame(string title, string platform, string yearReleased, string developers)
        : base(title, yearReleased)
        {
            Title = title;
            Platform = platform;
            YearReleased = yearReleased;
            Developers = developers;
        }

        public string GetDisplayText()
        {
            return ("Video Game: " + '"' + Title + '"' + " on the " + Platform + " platform released in " + YearReleased + " by " + Developers + ".");
        }
    }
}