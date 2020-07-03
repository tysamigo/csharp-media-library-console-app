namespace project_csharp_media_library_console_app
{
    class Album
    {
        public readonly string Title;
        public readonly string Artist;
        public readonly string YearReleased;
        public string Loanee;
        public bool OnLoan;

        public Album(string title, string artist, string yearReleased)
        {
            Title = title;
            Artist = artist;
            YearReleased = yearReleased;
        }

        public void LoanMedia()
        {
            OnLoan = true;
        }
        
        public void LoanMedia(string loanee)
        {
            Loanee = loanee;
            LoanMedia();
        }

        public void ReturnMedia()
        {
            Loanee = null;
            OnLoan = false;
        }

        public string GetDisplayText()
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
}