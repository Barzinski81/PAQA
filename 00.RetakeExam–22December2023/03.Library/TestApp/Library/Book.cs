namespace TestApp.Library
{
    public class Book
    {
        public Book(string isbn, string title, string author)
        {
            this.Isbn = isbn;
            this.Title = title;
            this.Author = author;
        }

        public string Isbn { get; }

        public string Title { get; }

        public string Author { get; }
    }
}
