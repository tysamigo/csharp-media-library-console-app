namespace project_csharp_media_library_console_app
{
    class VideoGame : MediaType
    {
        public readonly string Platform;
        public readonly string Developers;

        public VideoGame(string title, string platform, string yearReleased, string developers)
        : base(title, yearReleased)
        {
            Platform = platform;
            Developers = developers;
        }

        public string GetDisplayText()
        {
            string text = "Video Game: " + '"' + Title + '"' + " by " + Developers + " for the " + Platform + " platform released in " + YearReleased;

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