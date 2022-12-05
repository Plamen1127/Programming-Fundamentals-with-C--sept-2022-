using System;
using System.Linq;
using System.Text;

namespace _3.Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "asdasdsadsadasdasdasdasdasdasdasdasdasdas";
            Console.WriteLine($"Unique symbols used: {message.Distinct().Count()}");
        }
    }
}
