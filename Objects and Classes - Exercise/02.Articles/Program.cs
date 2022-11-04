using System;
using System.Linq;

namespace _09.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                             .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                             .ToArray();

            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article article = new Article(title, content, author);

            int commandsCount = int.Parse(Console.ReadLine());

            while (commandsCount > 0)
            {
                string[] data = Console.ReadLine()
                                .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();

                string command = data[0];

                switch (command)
                {
                    case "Edit":

                        string newContent = data[1];
                        article.Edit(newContent);

                        break;

                    case "ChangeAuthor":

                        string newAuthor = data[1];
                        article.ChangeAuthor(newAuthor);

                        break;

                    case "Rename":

                        string newTitle = data[1];
                        article.Rename(newTitle);

                        break;
                }

                commandsCount--;
            }

            Console.WriteLine(article.ToString());

        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }
        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
}