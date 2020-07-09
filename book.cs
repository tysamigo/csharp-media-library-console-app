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
                return "Album: " + '"' + Title + '"' + " by " + Author + " released in " + YearReleased + OnLoanDisplayText;

            }
        }
    }
}