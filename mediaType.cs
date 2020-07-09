using System;

namespace project_csharp_media_library_console_app
{
    class MediaType
    {
        // private readonly string _title;

        // public string Title
        // {
        //     get { return _title;}
        // }

        public string Title { get; private set; }
        public string YearReleased { get; private set;}
        public string Loanee { get; private set;} = "";
        public bool OnLoan { get; private set;} = false;

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