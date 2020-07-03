namespace project_csharp_media_library_console_app
{
    class VideoGame
    {
        public string Title;
        public string Platform;
        public string YearReleased;
        public string Developers;

        public VideoGame(string title, string platform, string yearReleased, string developers)
        {
            Title = title;
            Platform = platform;
            YearReleased = yearReleased;
            Developers = developers;
        }
    }
}