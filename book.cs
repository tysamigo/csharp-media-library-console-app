namespace project_csharp_media_library_console_app
{
    class Book
    {
        public readonly string Title;
        public readonly string Author;
        public readonly string YearReleased;

        public Book(string title, string author, string yearReleased)
        {
            Title = title;
            Author = author;
            YearReleased = yearReleased;
        }

        public string GetDisplayText()
        {
            return ("Book: " + '"' + Title + '"' + " by " + Author + " released in " + YearReleased);
        }
    }
}