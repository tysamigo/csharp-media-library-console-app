namespace project_csharp_media_library_console_app
{
    class Book : MediaType
    {
        public readonly string Author;

        public Book(string title, string author, string yearReleased)
        : base(title, yearReleased)
        {
            Author = author;
        }

        public string GetDisplayText()
        {
            string text = "Album: " + '"' + Title + '"' + " by " + Author + " released in " + YearReleased;

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