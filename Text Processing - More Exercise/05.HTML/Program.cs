using System;

namespace _05.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");
            string content = Console.ReadLine();
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");
            string comment;

            while ((comment = Console.ReadLine()) != "end of comments")
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comment}");
                Console.WriteLine("</div>");
            }
        }
    }
}
