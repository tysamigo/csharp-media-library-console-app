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
            return ("Book: " + '"' + Title + '"' + " by " + Author + " released in " + YearReleased);
        }
    }
}