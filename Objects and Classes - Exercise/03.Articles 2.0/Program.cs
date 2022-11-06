using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Article article = new Article();

            while (count > 0)
            {
                string[] input = Console.ReadLine()
                                .Split(", ")
                                .ToArray();

                string title = input[0];
                string content = input[1];
                string author = input[2];

                article.Articles.Add(new Article(title, content, author));

                count--;

            }

            string order = Console.ReadLine();

            if (order == "author")
            {
                foreach (var item in article.Articles)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else if (order == "content")
            {
                foreach (var item in article.Articles)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                foreach (var item in article.Articles)
                {
                    Console.WriteLine(item.ToString());
                }
            }

        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public List<Article> Articles { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public Article()
        {
            Articles = new List<Article>();
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
