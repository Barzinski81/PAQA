using System.Reflection.Metadata;

namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                string commandType = command[0];
                string newText = command[1];

                if (commandType == "Edit")
                {
                    article.Edit(newText);
                }

                else if (commandType == "ChangeAuthor")
                {
                    article.ChangeAuthor(newText);
                }

                else if (commandType == "Rename")
                {
                    article.Rename(newText);
                }
            }

            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit (string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor (string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename (string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }

}
