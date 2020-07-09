namespace project_csharp_media_library_console_app
{
    class Book : MediaType
    {
        public string Author { get; private set; }

        public Book(string title, string author, string yearReleased)
        : base(title, yearReleased)
        {
            Author = author;
        }

        public string DisplayText
        {
            get
            {
                string text = "Book: " + '"' + Title + '"' + " by " + Author + " released in " + YearReleased;

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
}