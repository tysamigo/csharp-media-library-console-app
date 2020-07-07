using System;

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
            if(string.IsNullOrEmpty(title))
            {
                throw new Exception("A media type must have a title");
            }
            
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