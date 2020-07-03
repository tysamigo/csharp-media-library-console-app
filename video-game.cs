namespace project_csharp_media_library_console_app
{
    class VideoGame
    {
        public readonly string Title;
        public readonly string Platform;
        public readonly string YearReleased;
        public readonly string Developers;

        public VideoGame(string title, string platform, string yearReleased, string developers)
        {
            Title = title;
            Platform = platform;
            YearReleased = yearReleased;
            Developers = developers;
        }
    }
}