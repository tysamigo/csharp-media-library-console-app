namespace project_csharp_media_library_console_app
{
    class MediaType
    {
        public string Title;
        public string YearReleased;
        public string Loanee;
        public bool OnLoan;

        public MediaType(string title, string yearReleased)
        {
            Title = title;
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
    }
}