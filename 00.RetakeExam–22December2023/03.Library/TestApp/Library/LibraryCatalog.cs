using System.Text;

namespace TestApp.Library
{
    public class LibraryCatalog
    {
        private readonly Dictionary<string, Book> _catalog = new();

        public void AddBook(string isbn, string title, string author)
        {
            Book newBook = new(isbn, title, author);
            this._catalog.Add(isbn, newBook);
        }

        public Book GetBook(string isbn)
        {
            bool exists = this._catalog.TryGetValue(isbn, out Book? book);
            if (!exists)
            {
                throw new ArgumentException("Book with given ISBN does not exist.");
            }

            return book!;
        }

        public string DisplayCatalog()
        {
            if (this._catalog.Count == 0)
            {
                return string.Empty;
            }

            StringBuilder sb = new();

            sb.AppendLine("Library Catalog:");
            foreach (Book book in this._catalog.Values)
            {
                sb.AppendLine($"{book.Title} by {book.Author} (ISBN: {book.Isbn})");
            }

            return sb.ToString().Trim();
        }
    }    
}



